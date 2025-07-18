import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App';
import { App as AntdApp } from 'antd';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <AntdApp>
      <App />
    </AntdApp>
  </React.StrictMode>
);

