import { AxiosResponse } from "axios";
import { JournalEntry } from "../models/media";
import http from "./http";

export const createLog = async (data: JournalEntry): Promise<AxiosResponse> => {
    return http.post("/api/jpurnal/v1/text-updates/save-text-update", data);
}
