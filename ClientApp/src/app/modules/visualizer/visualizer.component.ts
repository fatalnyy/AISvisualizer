import { Component, OnInit, OnChanges, Input, SimpleChange, SimpleChanges } from '@angular/core';
import { DecodeService } from '../../Shared/Services/decode.service';
import { ToastrService } from 'ngx-toastr';
import { DecodedMessages } from '../../Shared/Models/decodedMessages.interface';
import Map from 'ol/Map';
import TileLayer from 'ol/layer/Tile';
import OSM from 'ol/source/OSM';
import View from 'ol/View';
import { fromLonLat } from 'ol/proj.js';
import VectorLayer from 'ol/layer/Vector';
import VectorSource from 'ol/source/Vector';
import { forEachCorner } from 'ol/extent';
import { Feature, Overlay } from 'ol';
import Geometry from 'ol/geom/Geometry';
import Point from 'ol/geom/Point';
import {Icon, Style} from 'ol/style.js';
import { getVectorContext } from 'ol/render';
import TileJSON from 'ol/source/TileJSON';
import Tile from 'ol/layer/Tile';
import { composeCssTransform } from 'ol/transform';
import olms from 'ol-mapbox-style';
import { apply } from 'ol-mapbox-style';
import WebGLPointsLayer from 'ol/layer/WebGLPoints';
import { SymbolType, LiteralStyle } from 'ol/style/LiteralStyle';
import { MessageType1 } from '../../Shared/Models/messageType1.interface';
import Control from 'ol/control/Control';
import { MessageType123Headers } from '../../Shared/Helpers/messageType123Headers.enum';
import { MessageType4Headers } from '../../Shared/Helpers/messageType4Headers.enum';
import { MessageType5Headers } from '../../Shared/Helpers/messageType5Headers.enum';
import { MessageType9Headers } from '../../Shared/Helpers/messageType9Headers.enum';
import { MessageType21Headers } from '../../Shared/Helpers/messageType21Headers.enum';
import { interval } from 'rxjs';

@Component({
  selector: 'app-visualizer',
  templateUrl: './visualizer.component.html',
  styleUrls: ['./visualizer.component.scss']
})
export class VisualizerComponent implements OnInit{
  decodedMessages: DecodedMessages;
  latitude: number;
  longitude: number;
  zoom: number;
  saveToDb: boolean = false;
  map: Map;
  vectorLayer: VectorLayer;
  vectorSource: VectorSource;
  vectorFeatures: Feature<Geometry>[];
  vectorFeatures4: Feature<Geometry>[];
  vectorFeatures9: Feature<Geometry>[];
  vectorFeatures21: Feature<Geometry>[];
  pointsLayerType1: WebGLPointsLayer;
  pointsLayerType2: WebGLPointsLayer;
  pointsLayerType3: WebGLPointsLayer;
  pointsLayerType4: WebGLPointsLayer;
  pointsLayerType9: WebGLPointsLayer;
  pointsLayerType21: WebGLPointsLayer;
  marker: any;
  messagesType123Headers: string[] = Object.values(MessageType123Headers);
  messagesType4Headers: string[] = Object.values(MessageType4Headers);
  messagesType5Headers: string[] = Object.values(MessageType5Headers);
  messagesType9Headers: string[] = Object.values(MessageType9Headers);
  messagesType21Headers: string[] = Object.values(MessageType21Headers);
  progress: any;
  subscription: any;

  constructor(private readonly decodeService: DecodeService, private readonly toastr: ToastrService) { }

  ngOnInit(): void {
    this.initializeMap();

  }

  initializeMap() {
    let styleJson = 'https://api.maptiler.com/maps/topo/style.json?key=TrkPJurOFUX1t3iQOGg2';

    this.map = new Map({
      target: 'map',    
      view: new View({
        center: fromLonLat([0, 0]),
        zoom: 2
      })
    });

    olms(this.map, styleJson);
  }

  initializePopup(): void {
    const container = document.getElementById('popup');
    const closer = document.getElementById('popup-closer');
    container.style.display = "block";
    let marker: any;

    const overlay = new Overlay({
      element: container,
      autoPan: true,
      autoPanAnimation: {
        duration: 250
      }
    });

    this.map.addOverlay(overlay);
    var self = this;

    this.map.on('singleclick', function (evt) {
        self.marker = evt.map.forEachFeatureAtPixel(evt.pixel, function (feature) {
        let description = feature.get("description");
        return description;
        });

        if (self.marker) {
          let coordinate = evt.coordinate;
          overlay.setPosition(coordinate);
        }
    });

    this.marker = marker;
    closer.onclick = function () {
      overlay.setPosition(undefined);
      closer.blur();
      return false;
    };
  }

  getVectorSource(messages): VectorSource {
    let vectorFeatures: Feature<Geometry>[] = [];
    messages.forEach((message) => {
      let feature = new Feature({
        geometry: new Point(fromLonLat([message.longitude, message.latitude])),
        description: message
      });

      vectorFeatures.push(feature);
    });

    return new VectorSource({
      features: vectorFeatures,
    });
  }

  getStyle(icon: string): LiteralStyle {
    return {
      symbol: {
        symbolType: SymbolType.IMAGE,
        src: 'assets/' + icon,
        size: 30,
        rotateWithView: false,
        offset: [ 0, 9 ]
      }
    };
  }

  getPointsLayers(vectorSource: VectorSource, icon: string): WebGLPointsLayer {
    return new WebGLPointsLayer({
      source: vectorSource,
      style: this.getStyle(icon)   
    });
  }

  setData(): void {

    if (this.pointsLayerType1) this.map.removeLayer(this.pointsLayerType1);
    if (this.pointsLayerType2) this.map.removeLayer(this.pointsLayerType2);
    if (this.pointsLayerType3) this.map.removeLayer(this.pointsLayerType3);
    if (this.pointsLayerType4) this.map.removeLayer(this.pointsLayerType4);
    if (this.pointsLayerType9) this.map.removeLayer(this.pointsLayerType9);
    if (this.pointsLayerType21) this.map.removeLayer(this.pointsLayerType21);

    let messagesType1 = this.decodedMessages.messagesType1;
    let messagesType2 = this.decodedMessages.messagesType2;
    let messagesType3 = this.decodedMessages.messagesType3;
    let messagesType4 = this.decodedMessages.messagesType4;
    let messagesType9 = this.decodedMessages.messagesType9;
    let messagesType21 = this.decodedMessages.messagesType21;

    let vectorSourceType1: VectorSource = this.getVectorSource(messagesType1);
    let vectorSourceType2: VectorSource = this.getVectorSource(messagesType2);
    let vectorSourceType3: VectorSource = this.getVectorSource(messagesType3);
    let vectorSourceType4: VectorSource = this.getVectorSource(messagesType4);
    let vectorSourceType9: VectorSource = this.getVectorSource(messagesType9);
    let vectorSourceType21: VectorSource = this.getVectorSource(messagesType21);

    this.pointsLayerType1 = this.getPointsLayers(vectorSourceType1, 'shipType1.svg');
    this.pointsLayerType2 = this.getPointsLayers(vectorSourceType2, 'shipType2.svg');
    this.pointsLayerType3 = this.getPointsLayers(vectorSourceType3, 'shipType3.svg');
    this.pointsLayerType4 = this.getPointsLayers(vectorSourceType4, 'type4.svg');
    this.pointsLayerType9 = this.getPointsLayers(vectorSourceType9, 'type9.svg');
    this.pointsLayerType21 = this.getPointsLayers(vectorSourceType21, 'type211.svg');

    this.map.addLayer(this.pointsLayerType1);
    this.map.addLayer(this.pointsLayerType2);
    this.map.addLayer(this.pointsLayerType3);
    this.map.addLayer(this.pointsLayerType4);
    this.map.addLayer(this.pointsLayerType9);
    this.map.addLayer(this.pointsLayerType21);

    this.initializePopup();
  }

  public uploadFiles = (files) => {
    if (files.length === 0)
      return;

    const formData = new FormData();
    formData.append("saveToDb", String(this.saveToDb));

    for (let file of files)
      formData.append("files", file);

    this.getProgress();
    this.decodeService.decodeFromFiles(formData).subscribe(response => {
      this.decodedMessages = response;
      this.setData();
      this.subscription.unsubscribe();
    }, error => {
        this.toastr.error(error, 'Problem!');
    });
  }

  public getProgress(): void {
    document.getElementById('progressBar').style.display = "block";
    this.subscription = interval(1000).subscribe(() => {
      this.decodeService.getProgress().subscribe(response => {
        this.progress = response;
      });
    });
  }
}
