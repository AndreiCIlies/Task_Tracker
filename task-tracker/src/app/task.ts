import { Status } from "./status_enum";

export interface Task {
    id: string;
    name: string;
    description: string;
    assignedTo: string;
    dueDate: Date;
    status: Status;
}
