﻿export interface JournalEntry {
    id?: number;
    date: Date;
    title: string;
    description: string
}
export interface VideoLog {
    id?: number;
    date: Date;
    fileName: string;
    content: string
}

export default interface IFile {
    url: string,
    name: string,
}