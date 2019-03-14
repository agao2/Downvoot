import React, { Component } from 'react';
import './Login.css'

class Login extends Component {

  constructor(props) {
    super(props);
    this.state = {
      username: "",
      password: ""
    }
  }

  onChange = (event) => {    
    let state = this.state;
    state[event.target.id] = event.target.value;
  }

  onSubmit = () => {
    console.log(this.state.username);
    console.log(this.state.password);
  }

  render() {
    return (
      <div className="box" >
        <h1>login</h1>
        <input type="text" name="username" id="username" placeholder="Username" autoComplete="off" defaultValue={this.state.username} onChange={this.onChange} />
        <input type="password" name="password" id="password" placeholder="Password" autoComplete="off" defaultValue={this.state.password} onChange={this.onChange} />
        <input type="submit" id="submit" defaultValue="login" onClick={this.onSubmit} />
      </div>
    );
  }


}

export default Login;