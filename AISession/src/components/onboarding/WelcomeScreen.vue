<script setup lang="ts">
import { defineEmits } from 'vue'

const emit = defineEmits(['next'])

const handleGetStarted = () => {
  emit('next')
}
</script>

<template>
  <div class="welcome-screen">
    <div class="content">
      <h1 class="title">Welcome to <span class="highlight">AISession</span></h1>
      <p class="subtitle">Your intelligent workspace for the future</p>
      
      <div class="features">
        <div class="feature">
          <span class="icon">🚀</span>
          <h3>Smart Automation</h3>
          <p>Streamline your workflow with AI-powered tools</p>
        </div>
        <div class="feature">
          <span class="icon">🤝</span>
          <h3>Collaboration</h3>
          <p>Work together seamlessly with your team</p>
        </div>
        <div class="feature">
          <span class="icon">🔒</span>
          <h3>Secure</h3>
          <p>Enterprise-grade security for your data</p>
        </div>
      </div>

      <button class="get-started-btn" @click="handleGetStarted">
        Get Started
        <span class="arrow">→</span>
      </button>
    </div>
  </div>
</template>

<style scoped>
.welcome-screen {
  min-height: 100vh;
  display: flex;
  align-items: center;
  justify-content: center;
  padding: 2rem;
  background: linear-gradient(135deg, #f5f7fa 0%, #e4e9f2 100%);
}

.content {
  max-width: 800px;
  text-align: center;
}

.title {
  font-size: 3.5rem;
  font-weight: 700;
  margin-bottom: 1rem;
  background: linear-gradient(135deg, #2c3e50 0%, #3498db 100%);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
  animation: fadeIn 0.8s ease-out;
}

.highlight {
  color: #3498db;
  -webkit-text-fill-color: #3498db;
}

.subtitle {
  font-size: 1.5rem;
  color: #666;
  margin-bottom: 4rem;
  animation: fadeIn 0.8s ease-out 0.2s backwards;
}

.features {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
  gap: 2rem;
  margin-bottom: 4rem;
}

.feature {
  background: white;
  padding: 2rem;
  border-radius: 12px;
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.05);
  transition: transform 0.3s ease;
  animation: fadeIn 0.8s ease-out 0.4s backwards;
}

.feature:hover {
  transform: translateY(-5px);
}

.icon {
  font-size: 2.5rem;
  margin-bottom: 1rem;
  display: block;
}

.feature h3 {
  font-size: 1.25rem;
  margin-bottom: 0.5rem;
  color: #2c3e50;
}

.feature p {
  color: #666;
  font-size: 0.95rem;
}

.get-started-btn {
  font-size: 1.25rem;
  padding: 1rem 2.5rem;
  background: linear-gradient(135deg, #3498db 0%, #2980b9 100%);
  color: white;
  border: none;
  border-radius: 50px;
  cursor: pointer;
  transition: transform 0.3s ease, box-shadow 0.3s ease;
  animation: fadeIn 0.8s ease-out 0.6s backwards;
  display: inline-flex;
  align-items: center;
  gap: 0.5rem;
}

.get-started-btn:hover {
  transform: translateY(-2px);
  box-shadow: 0 4px 12px rgba(52, 152, 219, 0.3);
}

.arrow {
  transition: transform 0.3s ease;
}

.get-started-btn:hover .arrow {
  transform: translateX(5px);
}

@keyframes fadeIn {
  from {
    opacity: 0;
    transform: translateY(20px);
  }
  to {
    opacity: 1;
    transform: translateY(0);
  }
}

@media (max-width: 768px) {
  .title {
    font-size: 2.5rem;
  }
  
  .subtitle {
    font-size: 1.25rem;
  }
  
  .features {
    grid-template-columns: 1fr;
  }
}
</style>
