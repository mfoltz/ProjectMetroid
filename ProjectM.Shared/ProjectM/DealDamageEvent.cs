// Decompiled with JetBrains decompiler
// Type: ProjectM.DealDamageEvent
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
  public struct DealDamageEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaterialModifiers;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_MainType;
    private static readonly System.IntPtr NativeFieldInfoPtr_MainFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResourceModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_RawDamage;
    private static readonly System.IntPtr NativeFieldInfoPtr_RawDamagePercent;
    private static readonly System.IntPtr NativeFieldInfoPtr_Modifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_DealDamageFlags;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_MainDamageType_Single_Single_EntityTypeModifiers_Entity_Single_Single_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasFlag_Public_Boolean_DealDamageFlag_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDealDamageEvent_Public_Static_Entity_EntityCommandBuffer_Entity_DealDamageParameters_Entity_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDealDamageEvent_Public_Static_Entity_EntityCommandBuffer_Entity_MainDamageType_Single_Single_EntityTypeModifiers_Entity_Single_Single_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDealDamageEvent_Public_Static_Entity_EntityManager_Entity_DealDamageParameters_Entity_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDealDamageEvent_Public_Static_Entity_EntityManager_Entity_MainDamageType_Single_Single_EntityTypeModifiers_Entity_Single_Single_Single_Int32_0;
    [FieldOffset(0)]
    public EntityTypeModifiers MaterialModifiers;
    [FieldOffset(84)]
    public Entity Target;
    [FieldOffset(92)]
    public Entity SpellSource;
    [FieldOffset(100)]
    public readonly MainDamageType MainType;
    [FieldOffset(104)]
    public readonly float MainFactor;
    [FieldOffset(108)]
    public readonly float ResourceModifier;
    [FieldOffset(112)]
    public readonly float RawDamage;
    [FieldOffset(116)]
    public readonly float RawDamagePercent;
    [FieldOffset(120)]
    public readonly float Modifier;
    [FieldOffset(124)]
    public readonly int DealDamageFlags;

    [CallerCount(0)]
    public unsafe DealDamageEvent(
      Entity target,
      MainDamageType mainType,
      float mainFactor,
      float resourceModifier,
      EntityTypeModifiers materialModifiers,
      Entity source,
      float rawDamage,
      float rawDamagePercent,
      float modifier,
      int dealDamageFlags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mainType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mainFactor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &resourceModifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &materialModifiers;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &rawDamage;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &rawDamagePercent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &modifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &dealDamageFlags;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DealDamageEvent.NativeMethodInfoPtr__ctor_Public_Void_Entity_MainDamageType_Single_Single_EntityTypeModifiers_Entity_Single_Single_Single_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 737243, RefRangeEnd = 737246, XrefRangeStart = 737243, XrefRangeEnd = 737243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasFlag(DealDamageFlag flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DealDamageEvent.NativeMethodInfoPtr_HasFlag_Public_Boolean_DealDamageFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 737249, RefRangeEnd = 737251, XrefRangeStart = 737246, XrefRangeEnd = 737249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateDealDamageEvent(
      EntityCommandBuffer commandBuffer,
      Entity entity,
      DealDamageParameters parameters,
      Entity source,
      float modifier = 1f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &parameters;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &modifier;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DealDamageEvent.NativeMethodInfoPtr_CreateDealDamageEvent_Public_Static_Entity_EntityCommandBuffer_Entity_DealDamageParameters_Entity_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 737255, RefRangeEnd = 737258, XrefRangeStart = 737251, XrefRangeEnd = 737255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateDealDamageEvent(
      EntityCommandBuffer commandBuffer,
      Entity entity,
      MainDamageType mainType,
      float mainFactor,
      float resourceModifier,
      EntityTypeModifiers materialModifier,
      Entity source,
      float rawDamage = 0.0f,
      float rawDamagePercentage = 0.0f,
      float modifier = 1f,
      int dealDamageFlags = 2048)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[11];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mainType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mainFactor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &resourceModifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &materialModifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &rawDamage;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &rawDamagePercentage;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &modifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &dealDamageFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DealDamageEvent.NativeMethodInfoPtr_CreateDealDamageEvent_Public_Static_Entity_EntityCommandBuffer_Entity_MainDamageType_Single_Single_EntityTypeModifiers_Entity_Single_Single_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 737261, RefRangeEnd = 737262, XrefRangeStart = 737258, XrefRangeEnd = 737261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateDealDamageEvent(
      EntityManager entityManager,
      Entity entity,
      DealDamageParameters parameters,
      Entity source,
      float modifier = 1f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &parameters;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &modifier;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DealDamageEvent.NativeMethodInfoPtr_CreateDealDamageEvent_Public_Static_Entity_EntityManager_Entity_DealDamageParameters_Entity_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 737266, RefRangeEnd = 737272, XrefRangeStart = 737262, XrefRangeEnd = 737266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateDealDamageEvent(
      EntityManager entityManager,
      Entity entity,
      MainDamageType mainType,
      float mainFactor,
      float resourceModifier,
      EntityTypeModifiers materialModifier,
      Entity source,
      float rawDamage = 0.0f,
      float rawDamagePercent = 0.0f,
      float modifier = 1f,
      int dealDamageFlags = 2050)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[11];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mainType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mainFactor;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &resourceModifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &materialModifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &rawDamage;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &rawDamagePercent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &modifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &dealDamageFlags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DealDamageEvent.NativeMethodInfoPtr_CreateDealDamageEvent_Public_Static_Entity_EntityManager_Entity_MainDamageType_Single_Single_EntityTypeModifiers_Entity_Single_Single_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DealDamageEvent()
    {
      Il2CppClassPointerStore<DealDamageEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DealDamageEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealDamageEvent>.NativeClassPtr);
      DealDamageEvent.NativeFieldInfoPtr_MaterialModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEvent>.NativeClassPtr, nameof (MaterialModifiers));
      DealDamageEvent.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEvent>.NativeClassPtr, nameof (Target));
      DealDamageEvent.NativeFieldInfoPtr_SpellSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEvent>.NativeClassPtr, nameof (SpellSource));
      DealDamageEvent.NativeFieldInfoPtr_MainType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEvent>.NativeClassPtr, nameof (MainType));
      DealDamageEvent.NativeFieldInfoPtr_MainFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEvent>.NativeClassPtr, nameof (MainFactor));
      DealDamageEvent.NativeFieldInfoPtr_ResourceModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEvent>.NativeClassPtr, nameof (ResourceModifier));
      DealDamageEvent.NativeFieldInfoPtr_RawDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEvent>.NativeClassPtr, nameof (RawDamage));
      DealDamageEvent.NativeFieldInfoPtr_RawDamagePercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEvent>.NativeClassPtr, nameof (RawDamagePercent));
      DealDamageEvent.NativeFieldInfoPtr_Modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEvent>.NativeClassPtr, nameof (Modifier));
      DealDamageEvent.NativeFieldInfoPtr_DealDamageFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEvent>.NativeClassPtr, nameof (DealDamageFlags));
      DealDamageEvent.NativeMethodInfoPtr__ctor_Public_Void_Entity_MainDamageType_Single_Single_EntityTypeModifiers_Entity_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageEvent>.NativeClassPtr, 100665120);
      DealDamageEvent.NativeMethodInfoPtr_HasFlag_Public_Boolean_DealDamageFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageEvent>.NativeClassPtr, 100665121);
      DealDamageEvent.NativeMethodInfoPtr_CreateDealDamageEvent_Public_Static_Entity_EntityCommandBuffer_Entity_DealDamageParameters_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageEvent>.NativeClassPtr, 100665122);
      DealDamageEvent.NativeMethodInfoPtr_CreateDealDamageEvent_Public_Static_Entity_EntityCommandBuffer_Entity_MainDamageType_Single_Single_EntityTypeModifiers_Entity_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageEvent>.NativeClassPtr, 100665123);
      DealDamageEvent.NativeMethodInfoPtr_CreateDealDamageEvent_Public_Static_Entity_EntityManager_Entity_DealDamageParameters_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageEvent>.NativeClassPtr, 100665124);
      DealDamageEvent.NativeMethodInfoPtr_CreateDealDamageEvent_Public_Static_Entity_EntityManager_Entity_MainDamageType_Single_Single_EntityTypeModifiers_Entity_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageEvent>.NativeClassPtr, 100665125);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DealDamageEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
