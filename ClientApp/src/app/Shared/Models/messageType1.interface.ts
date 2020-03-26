import { MessageType5 } from "./messageType5.interface";

export interface MessageType1 {
    id: number,
    date?: Date,
    messageType: string,
    repeat: number,
    mmsi: number,
    packet: string,
    channel: string,
    country: string,
    status: string,
    rot?: number,
    sog?: number,
    accuracy: string,
    longitude: number,
    latitude: number,
    cog?: number,
    hdg?: number,
    timestamp: number,
    maneuver: string,
    spare: string,
    raim: string,
    radioStatus: number,
    MessageType5: MessageType5
}
