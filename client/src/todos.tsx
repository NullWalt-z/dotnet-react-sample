import * as React from 'react';

// This model class obviously belongs in a separate file, but this is just a quick demo.
interface TodoItem {
    id: number;
    title: string;
    content: string;
}

interface State {
    items: TodoItem[];
}

export class Todos extends React.Component<{}, State> {
    state: State = { items: [] };

    componentDidMount() {
        fetch('/api/todos')
            .then(result => result.json())
            // JSON data sent by server matches TodoItem structure, so it can be directly cast.
            .then((resultItems: TodoItem[]) => {
                this.setState({ items: resultItems });
            });
    }

    render() {
        const items = this.state.items
            .sort((a, b) => a.id - b.id)
            .map(it => (
                <li key={it.id}><b>{it.title}:</b> {it.content} </li>
            ));
        return (
            <ol>
                {items}
            </ol>
        );
    }
}