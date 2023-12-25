// Decompiled with JetBrains decompiler
// Type: ProjectM.EntityAddUpdateJobs_RemovedJob`2
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public struct EntityAddUpdateJobs_RemovedJob<TComponent, TCompareComponent>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
    private static readonly System.IntPtr NativeFieldInfoPtr_EventDataType;
    private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
    private static readonly System.IntPtr NativeFieldInfoPtr_RemovedEventArchetype;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
    public EntityTypeHandle EntityType;
    public ComponentTypeHandle<EntityAddUpdateRemoveEventSystem<TComponent, TCompareComponent>.EventData> EventDataType;
    public EntityCommandBuffer.ParallelWriter CommandBuffer;
    public EntityArchetype RemovedEventArchetype;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994076, XrefRangeEnd = 994084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntityAddUpdateJobs_RemovedJob<TComponent, TCompareComponent>.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EntityAddUpdateJobs_RemovedJob()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<EntityAddUpdateJobs_RemovedJob<TComponent, TCompareComponent>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", "EntityAddUpdateJobs_RemovedJob`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TComponent>.NativeClassPtr)),
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCompareComponent>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityAddUpdateJobs_RemovedJob<TComponent, TCompareComponent>>.NativeClassPtr);
      EntityAddUpdateJobs_RemovedJob<TComponent, TCompareComponent>.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddUpdateJobs_RemovedJob<TComponent, TCompareComponent>>.NativeClassPtr, nameof (EntityType));
      EntityAddUpdateJobs_RemovedJob<TComponent, TCompareComponent>.NativeFieldInfoPtr_EventDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddUpdateJobs_RemovedJob<TComponent, TCompareComponent>>.NativeClassPtr, nameof (EventDataType));
      EntityAddUpdateJobs_RemovedJob<TComponent, TCompareComponent>.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddUpdateJobs_RemovedJob<TComponent, TCompareComponent>>.NativeClassPtr, nameof (CommandBuffer));
      EntityAddUpdateJobs_RemovedJob<TComponent, TCompareComponent>.NativeFieldInfoPtr_RemovedEventArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAddUpdateJobs_RemovedJob<TComponent, TCompareComponent>>.NativeClassPtr, nameof (RemovedEventArchetype));
      EntityAddUpdateJobs_RemovedJob<TComponent, TCompareComponent>.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAddUpdateJobs_RemovedJob<TComponent, TCompareComponent>>.NativeClassPtr, 100676761);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EntityAddUpdateJobs_RemovedJob<TComponent, TCompareComponent>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
