// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnChainTransitionEvent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpawnChainTransitionEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryTransitionId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryTransitionId;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnChain;
    private static readonly System.IntPtr NativeFieldInfoPtr_FromSpawnChainChild;
    private static readonly System.IntPtr NativeFieldInfoPtr_FromSpawnChainElementIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_MultiStepStartChainElementIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ForwardedAutoChainTransitionSurplus;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpawnChainTransitionEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateTransitionEvent_Public_Static_Void_EntityManager_Entity_FixedString32_FixedString32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateTransitionEvent_Public_Static_Void_EntityCommandBuffer_ComponentDataFromEntity_1_ActiveChildElement_ComponentDataFromEntity_1_SpawnChainChild_Entity_FixedString32_FixedString32_0;
    [FieldOffset(0)]
    public SpawnChainData.TransitionId PrimaryTransitionId;
    [FieldOffset(32)]
    public SpawnChainData.TransitionId SecondaryTransitionId;
    [FieldOffset(64)]
    public Entity SpawnChain;
    [FieldOffset(72)]
    public Entity FromSpawnChainChild;
    [FieldOffset(80)]
    public int FromSpawnChainElementIndex;
    [FieldOffset(84)]
    public int MultiStepStartChainElementIndex;
    [FieldOffset(88)]
    public double ForwardedAutoChainTransitionSurplus;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728438, XrefRangeEnd = 728441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionEvent.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 728448, RefRangeEnd = 728449, XrefRangeStart = 728441, XrefRangeEnd = 728448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(SpawnChainTransitionEvent other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionEvent.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpawnChainTransitionEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728449, XrefRangeEnd = 728452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionEvent.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 728474, RefRangeEnd = 728475, XrefRangeStart = 728452, XrefRangeEnd = 728474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateTransitionEvent(
      EntityManager entityManager,
      Entity spawnChainEntity,
      FixedString32 transitionId,
      FixedString32 secondaryTransitionId = default (FixedString32))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnChainEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &transitionId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &secondaryTransitionId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionEvent.NativeMethodInfoPtr_CreateTransitionEvent_Public_Static_Void_EntityManager_Entity_FixedString32_FixedString32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 728493, RefRangeEnd = 728495, XrefRangeStart = 728475, XrefRangeEnd = 728493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateTransitionEvent(
      EntityCommandBuffer spawnBuffer,
      ComponentDataFromEntity<SpawnChainData.ActiveChildElement> getActiveChildElement,
      ComponentDataFromEntity<SpawnChainChild> getSpawnChainChild,
      Entity spawnChainEntity,
      FixedString32 transitionId,
      FixedString32 secondaryTransitionId = default (FixedString32))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &spawnBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getActiveChildElement;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &getSpawnChainChild;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &spawnChainEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &transitionId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &secondaryTransitionId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnChainTransitionEvent.NativeMethodInfoPtr_CreateTransitionEvent_Public_Static_Void_EntityCommandBuffer_ComponentDataFromEntity_1_ActiveChildElement_ComponentDataFromEntity_1_SpawnChainChild_Entity_FixedString32_FixedString32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpawnChainTransitionEvent()
    {
      Il2CppClassPointerStore<SpawnChainTransitionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnChainTransitionEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainTransitionEvent>.NativeClassPtr);
      SpawnChainTransitionEvent.NativeFieldInfoPtr_PrimaryTransitionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionEvent>.NativeClassPtr, nameof (PrimaryTransitionId));
      SpawnChainTransitionEvent.NativeFieldInfoPtr_SecondaryTransitionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionEvent>.NativeClassPtr, nameof (SecondaryTransitionId));
      SpawnChainTransitionEvent.NativeFieldInfoPtr_SpawnChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionEvent>.NativeClassPtr, nameof (SpawnChain));
      SpawnChainTransitionEvent.NativeFieldInfoPtr_FromSpawnChainChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionEvent>.NativeClassPtr, nameof (FromSpawnChainChild));
      SpawnChainTransitionEvent.NativeFieldInfoPtr_FromSpawnChainElementIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionEvent>.NativeClassPtr, nameof (FromSpawnChainElementIndex));
      SpawnChainTransitionEvent.NativeFieldInfoPtr_MultiStepStartChainElementIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionEvent>.NativeClassPtr, nameof (MultiStepStartChainElementIndex));
      SpawnChainTransitionEvent.NativeFieldInfoPtr_ForwardedAutoChainTransitionSurplus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainTransitionEvent>.NativeClassPtr, nameof (ForwardedAutoChainTransitionSurplus));
      SpawnChainTransitionEvent.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionEvent>.NativeClassPtr, 100664489);
      SpawnChainTransitionEvent.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpawnChainTransitionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionEvent>.NativeClassPtr, 100664490);
      SpawnChainTransitionEvent.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionEvent>.NativeClassPtr, 100664491);
      SpawnChainTransitionEvent.NativeMethodInfoPtr_CreateTransitionEvent_Public_Static_Void_EntityManager_Entity_FixedString32_FixedString32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionEvent>.NativeClassPtr, 100664492);
      SpawnChainTransitionEvent.NativeMethodInfoPtr_CreateTransitionEvent_Public_Static_Void_EntityCommandBuffer_ComponentDataFromEntity_1_ActiveChildElement_ComponentDataFromEntity_1_SpawnChainChild_Entity_FixedString32_FixedString32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainTransitionEvent>.NativeClassPtr, 100664493);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainTransitionEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
