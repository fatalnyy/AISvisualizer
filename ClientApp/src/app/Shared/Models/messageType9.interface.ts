
export interface MessageType9 {
  id: number,
  date?: Date,
  messageType: string,
  repeat: number,
  mmsi: number,
  packet: string,
  channel: string,
  country: string,
  altitude: string,
  sog?: number,
  accuracy: string,
  longitude: number,
  latitude: number,
  cog?: number,
  timestamp: number,
  reserved: number,
  dte: string,
  assigned: string,
  raim: string,
  spare: number,
  radioStatus: number
}
