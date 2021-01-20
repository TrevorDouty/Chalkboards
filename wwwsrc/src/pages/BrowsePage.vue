<template>
  <div class="browse-page">
    <browse-component v-for="board in boards" :key="board.id" :board-prop="board" />
  </div>
</template>

<script>
import { BrowseComponent } from "../components/BrowseComponent"
export default {
  name: 'BrowsePage',
  setup() {
    return {}
  },
  components: { BrowseComponent }
}
</script>


<style lang="scss" scoped>

</style>
