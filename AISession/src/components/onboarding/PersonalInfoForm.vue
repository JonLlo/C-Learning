<script setup lang="ts">
import { ref } from 'vue'

const emit = defineEmits(['next', 'back'])

const form = ref({
  fullName: '',
  role: '',
  company: '',
  goals: ''
})

const roles = [
  'Developer',
  'Designer',
  'Product Manager',
  'Entrepreneur',
  'Student',
  'Other'
]

const handleSubmit = () => {
  // TODO: Validate and process form data
  emit('next', form.value)
}
</script>

<template>
  <div class="personal-info">
    <div class="form-container">
      <button class="back-btn" @click="$emit('back')">←</button>
      
      <h2 class="title">Tell us about yourself</h2>
      <p class="subtitle">Help us personalize your experience</p>

      <form @submit.prevent="handleSubmit" class="form">
        <div class="form-group">
          <label for="fullName">Full Name</label>
          <input 
            id="fullName"
            v-model="form.fullName"
            type="text"
            required
            placeholder="Enter your full name"
          >
        </div>

        <div class="form-group">
          <label for="role">What best describes your role?</label>
          <select 
            id="role"
            v-model="form.role"
            required
          >
            <option value="" disabled selected>Select your role</option>
            <option v-for="role in roles" :key="role" :value="role">
              {{ role }}
            </option>
          </select>
        </div>

        <div class="form-group">
          <label for="company">Company/Organization</label>
          <input 
            id="company"
            v-model="form.company"
            type="text"
            placeholder="Where do you work?"
          >
        </div>

        <div class="form-group">
          <label for="goals">What are your main goals?</label>
          <textarea 
            id="goals"
            v-model="form.goals"
            placeholder="Tell us what you hope to achieve..."
            rows="3"
          ></textarea>
        </div>

        <button type="submit" class="continue-btn">
          Continue
          <span class="arrow">→</span>
        </button>
      </form>
    </div>
  </div>
</template>

<style scoped>
.personal-info {
  min-height: 100vh;
  display: flex;
  align-items: center;
  justify-content: center;
  padding: 2rem;
  background: linear-gradient(135deg, #f5f7fa 0%, #e4e9f2 100%);
}

.form-container {
  background: white;
  padding: 3rem;
  border-radius: 16px;
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.05);
  width: 100%;
  max-width: 600px;
  position: relative;
  animation: slideIn 0.6s ease-out;
}

.back-btn {
  position: absolute;
  top: 2rem;
  left: 2rem;
  background: none;
  border: none;
  font-size: 1.5rem;
  color: #666;
  cursor: pointer;
  transition: transform 0.3s ease;
}

.back-btn:hover {
  transform: translateX(-5px);
}

.title {
  font-size: 2rem;
  color: #2c3e50;
  margin-bottom: 0.5rem;
  text-align: center;
}

.subtitle {
  color: #666;
  text-align: center;
  margin-bottom: 2rem;
}

.form {
  display: flex;
  flex-direction: column;
  gap: 1.5rem;
}

.form-group {
  display: flex;
  flex-direction: column;
  gap: 0.5rem;
}

label {
  font-weight: 500;
  color: #2c3e50;
}

input,
select,
textarea {
  padding: 0.75rem;
  border: 2px solid #e4e9f2;
  border-radius: 8px;
  font-size: 1rem;
  transition: border-color 0.3s ease;
}

input:focus,
select:focus,
textarea:focus {
  outline: none;
  border-color: #3498db;
}

textarea {
  resize: vertical;
  min-height: 100px;
}

.continue-btn {
  margin-top: 1rem;
  padding: 1rem 2rem;
  background: linear-gradient(135deg, #3498db 0%, #2980b9 100%);
  color: white;
  border: none;
  border-radius: 8px;
  cursor: pointer;
  font-size: 1.1rem;
  transition: transform 0.3s ease, box-shadow 0.3s ease;
  display: inline-flex;
  align-items: center;
  gap: 0.5rem;
}

.continue-btn:hover {
  transform: translateY(-2px);
  box-shadow: 0 4px 12px rgba(52, 152, 219, 0.3);
}

.arrow {
  transition: transform 0.3s ease;
}

.continue-btn:hover .arrow {
  transform: translateX(5px);
}

@keyframes slideIn {
  from {
    opacity: 0;
    transform: translateX(30px);
  }
  to {
    opacity: 1;
    transform: translateX(0);
  }
}

@media (max-width: 768px) {
  .form-container {
    padding: 2rem;
    margin: 1rem;
  }

  .title {
    font-size: 1.75rem;
  }

  .back-btn {
    top: 1.5rem;
    left: 1.5rem;
  }
}
</style>
