import { useEffect, useState } from 'react';
import './App.css';

interface Ticket {
    TicketId: number;
    Title: string;
    Description: string,
    Status: string,
    Priority: string,
    Category: string,
    CreatedAt: string,
    CompletedAt: string,
    ClosedAt: string,
 
}
function App() {
    const [tickets, setTickets] = useState<Ticket[]>();

    useEffect(() => {
        populateTicketData();
    }, []);

    const contents = tickets === undefined
        ? <p><em>Loading!!!... Please Wait!!!..... Loading!!! <a href="https://aka.ms/jspsintegrationreact">https://aka.ms/jspsintegrationreact</a> for more details.</em></p>
        : <table className="table table-striped" aria-labelledby="tableLabel">
            <thead>
                <tr>
                    <th>Title</th>
                    <th>Description</th>
                    <th>Status</th>
                    <th>Priority</th>
                    <th>Category</th>
                    <th>Created At</th>
                    <th>Completed At</th>
                    <th>Closed At</th>

                </tr>
            </thead>
            <tbody>
                {tickets.map(ticket =>
                    <tr key={ticket.TicketId}>
                        <td>{ticket.Title}</td>
                        <td>{ticket.Description}</td>
                        <td>{ticket.Status}</td>
                        <td>{ticket.Priority}</td>
                        <td>{ticket.Category}</td>
                        <td>{ticket.CreatedAt}</td>
                        <td>{ticket.CompletedAt}</td>
                        <td>{ticket.ClosedAt}</td>
                    </tr>
                )}
            </tbody>
        </table>;

    return (
        <div>
            <h1 id="tableLabel">Ticket Tracking System</h1>
            <p>Ticket Report </p>
            {contents}
        </div>
    );

    async function populateTicketData() {
        const response = await fetch('ticket');
        const data = await response.json();
        setTickets(data);
    }
}

export default App;