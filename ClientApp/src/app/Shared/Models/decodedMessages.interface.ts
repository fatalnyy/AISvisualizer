import { MessageType5 } from "./messageType5.interface";
import { MessageType4 } from "./messageType4.interface";
import { MessageType3 } from "./messageType3.interface";
import { MessageType2 } from "./messageType2.interface";
import { MessageType1 } from "./messageType1.interface";
import { MessageType21 } from "./messageType21.interface";
import { MessageType9 } from "./messageType9.interface";

export interface DecodedMessages {
  MessagesType1: MessageType1[],
  MessagesType2: MessageType2[],
  MessagesType3: MessageType3[],
  MessagesType4: MessageType4[],
  MessagesType5: MessageType5[],
  MessagesType9: MessageType9[],
  MessagesType21: MessageType21[],
}
