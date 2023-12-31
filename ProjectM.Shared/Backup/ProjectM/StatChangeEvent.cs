// Decompiled with JetBrains decompiler
// Type: ProjectM.StatChangeEvent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StatChangeEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StatChangeEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Source;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Change;
    private static readonly System.IntPtr NativeFieldInfoPtr_OriginalChange;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatChangeFlags;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_StatType_Single_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDefaultStatChangeFlags_Public_Static_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasFlag_Public_Boolean_StatChangeFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateStatChangeEvent_Public_Static_Entity_EntityCommandBuffer_StatType_Entity_Single_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateStatChangeEvent_Public_Static_Entity_ParallelWriter_StatType_Int32_Entity_Single_Int32_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateStatChangeEvent_Public_Static_Entity_EntityManager_StatType_Entity_Single_Int32_Entity_0;
    [FieldOffset(0)]
    public Entity StatChangeEntity;
    [FieldOffset(8)]
    public Entity Entity;
    [FieldOffset(16)]
    public Entity Source;
    [FieldOffset(24)]
    public StatType StatType;
    [FieldOffset(28)]
    public float Change;
    [FieldOffset(32)]
    public float OriginalChange;
    [FieldOffset(36)]
    public int StatChangeFlags;

    [CallerCount(0)]
    public unsafe StatChangeEvent(
      Entity statChangeEntity,
      Entity entity,
      StatType statType,
      float change,
      int statChangeFlags,
      Entity source)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &statChangeEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &statType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &change;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &statChangeFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_StatType_Single_Int32_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(21)]
    [CachedScanResults(RefRangeStart = 31081, RefRangeEnd = 31102, XrefRangeStart = 31081, XrefRangeEnd = 31102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int CreateDefaultStatChangeFlags()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeEvent.NativeMethodInfoPtr_CreateDefaultStatChangeFlags_Public_Static_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(28)]
    [CachedScanResults(RefRangeStart = 729203, RefRangeEnd = 729231, XrefRangeStart = 729203, XrefRangeEnd = 729203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasFlag(StatChangeFlag flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeEvent.NativeMethodInfoPtr_HasFlag_Public_Boolean_StatChangeFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 729235, RefRangeEnd = 729248, XrefRangeStart = 729231, XrefRangeEnd = 729235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateStatChangeEvent(
      EntityCommandBuffer commandBuffer,
      StatType statType,
      Entity entity,
      float change,
      int statChangeFlags,
      Entity source = default (Entity))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &statType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &change;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &statChangeFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeEvent.NativeMethodInfoPtr_CreateStatChangeEvent_Public_Static_Entity_EntityCommandBuffer_StatType_Entity_Single_Int32_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 729252, RefRangeEnd = 729255, XrefRangeStart = 729248, XrefRangeEnd = 729252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateStatChangeEvent(
      EntityCommandBuffer.ParallelWriter commandBuffer,
      StatType statType,
      int jobIndex,
      Entity entity,
      float change,
      int statChangeFlags,
      Entity source = default (Entity))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &statType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &jobIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &change;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &statChangeFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeEvent.NativeMethodInfoPtr_CreateStatChangeEvent_Public_Static_Entity_ParallelWriter_StatType_Int32_Entity_Single_Int32_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 729259, RefRangeEnd = 729271, XrefRangeStart = 729255, XrefRangeEnd = 729259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateStatChangeEvent(
      EntityManager entityManager,
      StatType statType,
      Entity entity,
      float change,
      int statChangeFlags,
      Entity source = default (Entity))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &statType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &change;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &statChangeFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatChangeEvent.NativeMethodInfoPtr_CreateStatChangeEvent_Public_Static_Entity_EntityManager_StatType_Entity_Single_Int32_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    static StatChangeEvent()
    {
      Il2CppClassPointerStore<StatChangeEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (StatChangeEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeEvent>.NativeClassPtr);
      StatChangeEvent.NativeFieldInfoPtr_StatChangeEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeEvent>.NativeClassPtr, nameof (StatChangeEntity));
      StatChangeEvent.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeEvent>.NativeClassPtr, nameof (Entity));
      StatChangeEvent.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeEvent>.NativeClassPtr, nameof (Source));
      StatChangeEvent.NativeFieldInfoPtr_StatType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeEvent>.NativeClassPtr, nameof (StatType));
      StatChangeEvent.NativeFieldInfoPtr_Change = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeEvent>.NativeClassPtr, nameof (Change));
      StatChangeEvent.NativeFieldInfoPtr_OriginalChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeEvent>.NativeClassPtr, nameof (OriginalChange));
      StatChangeEvent.NativeFieldInfoPtr_StatChangeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeEvent>.NativeClassPtr, nameof (StatChangeFlags));
      StatChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_StatType_Single_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeEvent>.NativeClassPtr, 100664569);
      StatChangeEvent.NativeMethodInfoPtr_CreateDefaultStatChangeFlags_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeEvent>.NativeClassPtr, 100664570);
      StatChangeEvent.NativeMethodInfoPtr_HasFlag_Public_Boolean_StatChangeFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeEvent>.NativeClassPtr, 100664571);
      StatChangeEvent.NativeMethodInfoPtr_CreateStatChangeEvent_Public_Static_Entity_EntityCommandBuffer_StatType_Entity_Single_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeEvent>.NativeClassPtr, 100664572);
      StatChangeEvent.NativeMethodInfoPtr_CreateStatChangeEvent_Public_Static_Entity_ParallelWriter_StatType_Int32_Entity_Single_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeEvent>.NativeClassPtr, 100664573);
      StatChangeEvent.NativeMethodInfoPtr_CreateStatChangeEvent_Public_Static_Entity_EntityManager_StatType_Entity_Single_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeEvent>.NativeClassPtr, 100664574);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatChangeEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
