import { check, sleep } from "k6";
import http from "k6/http";
import { htmlReport } from "https://raw.githubusercontent.com/benc-uk/k6-reporter/main/dist/bundle.js";
import { textSummary } from 'https://jslib.k6.io/k6-summary/0.0.2/index.js';

const url = "https://localhost:7245/teams-mapperly";
export const options = {
    stages: [
        { duration: '1m', target: 80 },
        { duration: '1m', target: 80 },
        { duration: '1m', target: 0 },
    ]
}

export default function () {
    const resAutomapper = http.get(url);
    check(resAutomapper, {
        "is status 200": (r) => r.status === 200
    });

    sleep(1);
};

export function handleSummary(data) {
    return {
        './logs/summary_automapper.html': htmlReport(data),
        'stdout': textSummary(data, { indent: ' ', enableColors: true })
    };
}