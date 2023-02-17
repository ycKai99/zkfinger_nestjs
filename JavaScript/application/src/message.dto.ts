export type Message = {
    event_Id: string;
    message: string;
    receiveddate: Date;
    processStatus?: MessageProcessStatusType;
}


export enum MessageProcessStatusType {
    'default' = '',
    'Start' = 'Start',
    'ProcessingStarted' = 'ProcessingStarted',
    'ProcessingReady' = 'ProcessingReady',
    'Done' = 'Done'
}