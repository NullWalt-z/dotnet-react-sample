import * as React from 'react';
import { Todos } from './todos';
import './app.css';

const logo = require('./logo.svg');

class App extends React.Component {
  render() {
    return (
      <div className="app">
        <header className="app-header">
          <img src={logo} className="app-logo" alt="logo" />
          <h1 className="app-title">Welcome to React</h1>
        </header>
        <Todos />
      </div>
    );
  }

}
export default App;