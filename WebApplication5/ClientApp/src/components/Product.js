import React, { Component } from 'react';

export class Product extends Component {
    static displayName = Product.name;

    constructor(props) {
        super(props);
        this.state = { forecasts: [], loading: true };
    }

    componentDidMount() {
        this.populateWeatherData();
    }

    static renderForecastsTable(forecasts) {
        return (
            <table className='table table-striped'>
                <thead>
                    <tr>
                        <th>ProductId</th>
                        <th>Name</th>
                        <th>ProductNumber</th>
                        <th>Color</th>
                    </tr>
                </thead>
                <tbody>
                    {forecasts.map(forecast =>
                        <tr key={forecast.productId}>
                            <td>{forecast.productId}</td>
                            <td>{forecast.name}</td>
                            <td>{forecast.productNumber}</td>
                            <td>{forecast.color}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Product.renderForecastsTable(this.state.forecasts);

        return (
            <div>
                <h1>Product</h1>
                <p>Ovo je samo testiranje komponente.</p>
                {contents}
            </div>
        );
    }

    async populateWeatherData() {
        //const response = await fetch('api/Product/ProductForecasts');
        const response = await fetch('api/Product');
        const data = await response.json();
        this.setState({ forecasts: data, loading: false });
    }
}
