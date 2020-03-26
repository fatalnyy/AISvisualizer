
export interface MessageType4 {
  id: number,
  date?: Date,
  messageType: string,
  repeat: number,
  mmsi: number,
  packet: string,
  channel: string,
  country: string,
  year: number,
  month: number,
  day: number,
  hour: number,
  minute: number,
  second: number,
  fixQuality: string,
  longitude: number,
  latitude: number,
  epfd: string,
  raim: string,
  spare: number,
  radioStatus: number
}
