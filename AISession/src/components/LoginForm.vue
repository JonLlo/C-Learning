<script setup lang="ts">
import { ref } from 'vue'

const email = ref('')
const password = ref('')
const error = ref('')

const handleSubmit = async () => {
  try {
    error.value = ''
    if (!email.value || !password.value) {
      error.value = 'Please fill in all fields'
      return
    }
    // TODO: Implement actual login logic here
    console.log('Login attempted with:', { email: email.value })
  } catch (e) {
    error.value = 'An error occurred during login'
    console.error(e)
  }
}
</script>

<template>
  <div class="login-container">
    <form @submit.prevent="handleSubmit" class="login-form">
      <h1>Welcome</h1>
      <p class="subtitle">Please sign in to continue</p>
      
      <div class="form-group">
        <label for="email">Email</label>
        <input 
          id="email"
          type="email" 
          v-model="email" 
          placeholder="Enter your email"
          required
        >
      </div>

      <div class="form-group">
        <label for="password">Password</label>
        <input 
          id="password"
          type="password" 
          v-model="password" 
          placeholder="Enter your password"
          required
        >
      </div>

      <p v-if="error" class="error">{{ error }}</p>

      <button type="submit" class="submit-button">Sign In</button>

      <p class="signup-link">
        Don't have an account? <a href="#signup">Sign up</a>
      </p>
    </form>
  </div>
</template>

<style scoped>
.login-container {
  display: flex;
  justify-content: center;
  align-items: center;
  min-height: 100vh;
  padding: 1rem;
  background-color: #f5f5f5;
}

.login-form {
  background: white;
  padding: 2rem;
  border-radius: 8px;
  box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
  width: 100%;
  max-width: 400px;
}

h1 {
  margin: 0 0 0.5rem 0;
  color: #2c3e50;
  font-size: 1.8rem;
}

.subtitle {
  color: #666;
  margin-bottom: 2rem;
}

.form-group {
  margin-bottom: 1.5rem;
}

label {
  display: block;
  margin-bottom: 0.5rem;
  color: #2c3e50;
  font-weight: 500;
}

input {
  width: 100%;
  padding: 0.75rem;
  border: 1px solid #ddd;
  border-radius: 4px;
  font-size: 1rem;
  transition: border-color 0.2s;
}

input:focus {
  outline: none;
  border-color: #42b883;
}

.error {
  color: #dc3545;
  font-size: 0.875rem;
  margin-top: -0.5rem;
  margin-bottom: 1rem;
}

.submit-button {
  width: 100%;
  padding: 0.75rem;
  background-color: #42b883;
  color: white;
  border: none;
  border-radius: 4px;
  font-size: 1rem;
  cursor: pointer;
  transition: background-color 0.2s;
}

.submit-button:hover {
  background-color: #3aa876;
}

.signup-link {
  text-align: center;
  margin-top: 1.5rem;
  color: #666;
}

.signup-link a {
  color: #42b883;
  text-decoration: none;
}

.signup-link a:hover {
  text-decoration: underline;
}
</style>
