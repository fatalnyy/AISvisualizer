import { MessageType5 } from "./messageType5.interface";
import { MessageType4 } from "./messageType4.interface";
import { MessageType3 } from "./messageType3.interface";
import { MessageType2 } from "./messageType2.interface";
import { MessageType1 } from "./messageType1.interface";
import { MessageType21 } from "./messageType21.interface";
import { MessageType9 } from "./messageType9.interface";

export interface DecodedMessages {
  messagesType1: MessageType1[],
  messagesType2: MessageType2[],
  messagesType3: MessageType3[],
  messagesType4: MessageType4[],
  messagesType5: MessageType5[],
  messagesType9: MessageType9[],
  messagesType21: MessageType21[],
}
