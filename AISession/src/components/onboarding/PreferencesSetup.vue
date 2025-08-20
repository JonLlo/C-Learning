<script setup lang="ts">
import { ref } from 'vue'

const emit = defineEmits(['complete', 'back'])

const preferences = ref({
  theme: 'light',
  notifications: true,
  updates: true,
  collaboration: false
})

const handleComplete = () => {
  // TODO: Save preferences
  emit('complete', preferences.value)
}
</script>

<template>
  <div class="preferences-setup">
    <div class="preferences-container">
      <button class="back-btn" @click="$emit('back')">←</button>

      <h2 class="title">Set Your Preferences</h2>
      <p class="subtitle">Customize your workspace experience</p>

      <div class="preferences-form">
        <div class="preference-group">
          <h3>Theme</h3>
          <div class="theme-selector">
            <label class="theme-option">
              <input 
                type="radio" 
                v-model="preferences.theme" 
                value="light"
              >
              <span class="theme-preview light">
                <span class="check">✓</span>
                Light
              </span>
            </label>
            
            <label class="theme-option">
              <input 
                type="radio" 
                v-model="preferences.theme" 
                value="dark"
              >
              <span class="theme-preview dark">
                <span class="check">✓</span>
                Dark
              </span>
            </label>
          </div>
        </div>

        <div class="preference-group">
          <h3>Notifications & Updates</h3>
          <div class="toggle-options">
            <label class="toggle">
              <input 
                type="checkbox"
                v-model="preferences.notifications"
              >
              <span class="toggle-slider"></span>
              <span class="toggle-label">
                Enable Notifications
                <small>Get important alerts about your workspace</small>
              </span>
            </label>

            <label class="toggle">
              <input 
                type="checkbox"
                v-model="preferences.updates"
              >
              <span class="toggle-slider"></span>
              <span class="toggle-label">
                Product Updates
                <small>Stay informed about new features</small>
              </span>
            </label>

            <label class="toggle">
              <input 
                type="checkbox"
                v-model="preferences.collaboration"
              >
              <span class="toggle-slider"></span>
              <span class="toggle-label">
                Collaboration Features
                <small>Enable team collaboration tools</small>
              </span>
            </label>
          </div>
        </div>

        <button @click="handleComplete" class="complete-btn">
          Complete Setup
          <span class="arrow">→</span>
        </button>
      </div>
    </div>
  </div>
</template>

<style scoped>
.preferences-setup {
  min-height: 100vh;
  display: flex;
  align-items: center;
  justify-content: center;
  padding: 2rem;
  background: linear-gradient(135deg, #f5f7fa 0%, #e4e9f2 100%);
}

.preferences-container {
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
  margin-bottom: 3rem;
}

.preferences-form {
  display: flex;
  flex-direction: column;
  gap: 2.5rem;
}

.preference-group {
  display: flex;
  flex-direction: column;
  gap: 1rem;
}

.preference-group h3 {
  color: #2c3e50;
  font-size: 1.25rem;
  margin-bottom: 0.5rem;
}

.theme-selector {
  display: flex;
  gap: 1rem;
  justify-content: center;
}

.theme-option input {
  display: none;
}

.theme-preview {
  display: flex;
  align-items: center;
  gap: 0.5rem;
  padding: 1rem 2rem;
  border-radius: 8px;
  cursor: pointer;
  transition: transform 0.3s ease, box-shadow 0.3s ease;
}

.theme-preview.light {
  background: #f8f9fa;
  color: #2c3e50;
  border: 2px solid #e4e9f2;
}

.theme-preview.dark {
  background: #2c3e50;
  color: white;
  border: 2px solid #2c3e50;
}

.check {
  opacity: 0;
  transition: opacity 0.3s ease;
}

.theme-option input:checked + .theme-preview {
  border-color: #3498db;
  transform: translateY(-2px);
  box-shadow: 0 4px 12px rgba(52, 152, 219, 0.1);
}

.theme-option input:checked + .theme-preview .check {
  opacity: 1;
}

.toggle-options {
  display: flex;
  flex-direction: column;
  gap: 1rem;
}

.toggle {
  display: flex;
  align-items: center;
  gap: 1rem;
  cursor: pointer;
}

.toggle-slider {
  position: relative;
  width: 50px;
  height: 26px;
  background: #e4e9f2;
  border-radius: 13px;
  transition: background 0.3s ease;
}

.toggle-slider:before {
  content: '';
  position: absolute;
  width: 22px;
  height: 22px;
  border-radius: 50%;
  background: white;
  top: 2px;
  left: 2px;
  transition: transform 0.3s ease;
}

.toggle input {
  display: none;
}

.toggle input:checked + .toggle-slider {
  background: #3498db;
}

.toggle input:checked + .toggle-slider:before {
  transform: translateX(24px);
}

.toggle-label {
  display: flex;
  flex-direction: column;
}

.toggle-label small {
  color: #666;
  font-size: 0.85rem;
}

.complete-btn {
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
  justify-content: center;
}

.complete-btn:hover {
  transform: translateY(-2px);
  box-shadow: 0 4px 12px rgba(52, 152, 219, 0.3);
}

.arrow {
  transition: transform 0.3s ease;
}

.complete-btn:hover .arrow {
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
  .preferences-container {
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

  .theme-selector {
    flex-direction: column;
  }
}
</style>
