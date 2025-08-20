<script setup lang="ts">
import { ref } from 'vue'
import WelcomeScreen from './WelcomeScreen.vue'
import PersonalInfoForm from './PersonalInfoForm.vue'
import PreferencesSetup from './PreferencesSetup.vue'

const currentStep = ref(0)
const userInfo = ref({})
const preferences = ref({})

const nextStep = (data?: any) => {
  if (data) {
    if (currentStep.value === 1) {
      userInfo.value = data
    } else if (currentStep.value === 2) {
      preferences.value = data
    }
  }
  currentStep.value++
}

const previousStep = () => {
  currentStep.value--
}

const completeOnboarding = (data: any) => {
  preferences.value = data
  // TODO: Save all collected data and redirect to main app
  console.log('Onboarding completed!', {
    userInfo: userInfo.value,
    preferences: preferences.value
  })
}
</script>

<template>
  <div class="onboarding-flow">
    <transition name="fade" mode="out-in">
      <WelcomeScreen 
        v-if="currentStep === 0"
        @next="nextStep"
      />
      
      <PersonalInfoForm
        v-else-if="currentStep === 1"
        @next="nextStep"
        @back="previousStep"
      />
      
      <PreferencesSetup
        v-else-if="currentStep === 2"
        @complete="completeOnboarding"
        @back="previousStep"
      />
    </transition>

    <div class="progress-indicator">
      <div 
        v-for="step in 3" 
        :key="step"
        class="progress-step"
        :class="{ active: currentStep >= step - 1 }"
      ></div>
    </div>
  </div>
</template>

<style scoped>
.onboarding-flow {
  position: relative;
  min-height: 100vh;
}

.progress-indicator {
  position: fixed;
  bottom: 2rem;
  left: 50%;
  transform: translateX(-50%);
  display: flex;
  gap: 0.5rem;
  padding: 1rem;
  background: white;
  border-radius: 20px;
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
}

.progress-step {
  width: 10px;
  height: 10px;
  border-radius: 50%;
  background: #e4e9f2;
  transition: background 0.3s ease, transform 0.3s ease;
}

.progress-step.active {
  background: #3498db;
  transform: scale(1.2);
}

.fade-enter-active,
.fade-leave-active {
  transition: opacity 0.3s ease;
}

.fade-enter-from,
.fade-leave-to {
  opacity: 0;
}
</style>
