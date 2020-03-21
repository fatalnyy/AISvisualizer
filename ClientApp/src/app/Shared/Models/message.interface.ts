export interface Message {
    id: number,
    messageType: string,
    repeat: number,
    mmsi: number,
    status: string,
    rot?: number,
    sog?: number,
    accuracy: string,
    longitude: number,
    latitude: number,
    cog?: number,
    hdg?: number,
    timestamp: string,
    maneuver: string,
    raim: string
}