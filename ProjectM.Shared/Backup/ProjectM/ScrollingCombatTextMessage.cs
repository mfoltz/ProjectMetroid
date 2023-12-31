// Decompiled with JetBrains decompiler
// Type: ProjectM.ScrollingCombatTextMessage
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ScrollingCombatTextMessage
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideLocalizedText;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_Source;
    private static readonly System.IntPtr NativeFieldInfoPtr_SourceObjectType;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodQuality;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideText;
    private static readonly System.IntPtr NativeFieldInfoPtr_CreateTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowForAll;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateLocal_Public_Static_Entity_EntityManager_Entity_FixedString512_float3_float3_Entity_Single_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateLocal_Public_Static_Entity_EntityCommandBuffer_Entity_FixedString512_float3_float3_Entity_Single_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateLocal_Public_Static_Entity_EntityCommandBuffer_Entity_AssetGuid_float3_Entity_float3_Single_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Entity_EntityManager_EntityCommandBuffer_Entity_AssetGuid_float3_float3_Entity_Single_PrefabGUID_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Entity_EntityManager_EntityCommandBuffer_Entity_Single_PrefabGUID_float3_Entity_Entity_PrefabGUID_Single_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Entity_EntityCommandBuffer_ComponentDataFromEntity_1_ControlledBy_Entity_Single_PrefabGUID_float3_Entity_Entity_PrefabGUID_Single_0;
    [FieldOffset(0)]
    public float3 Position;
    [FieldOffset(12)]
    public float3 OverrideColor;
    [FieldOffset(24)]
    public float Value;
    [FieldOffset(28)]
    public Il2CppSystem.Guid OverrideLocalizedText;
    [FieldOffset(44)]
    public PrefabGUID Type;
    [FieldOffset(48)]
    public NetworkedEntity Source;
    [FieldOffset(60)]
    public PrefabGUID SourceObjectType;
    [FieldOffset(64)]
    public float BloodQuality;
    [FieldOffset(68)]
    public NetworkedEntity Target;
    [FieldOffset(80)]
    public FixedString512 OverrideText;
    [FieldOffset(592)]
    public float CreateTime;
    [FieldOffset(596)]
    public bool ShowForAll;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 762675, RefRangeEnd = 762678, XrefRangeStart = 762661, XrefRangeEnd = 762675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateLocal(
      EntityManager entityManager,
      Entity sctPrefab,
      FixedString512 text,
      float3 position,
      float3 color,
      Entity entity,
      float value = 0.0f,
      PrefabGUID sctType = default (PrefabGUID))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sctPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &text;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &sctType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScrollingCombatTextMessage.NativeMethodInfoPtr_CreateLocal_Public_Static_Entity_EntityManager_Entity_FixedString512_float3_float3_Entity_Single_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 762692, RefRangeEnd = 762695, XrefRangeStart = 762678, XrefRangeEnd = 762692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateLocal(
      EntityCommandBuffer commandBuffer,
      Entity sctPrefab,
      FixedString512 text,
      float3 position,
      float3 color,
      Entity entity,
      float value = 0.0f,
      PrefabGUID sctType = default (PrefabGUID))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sctPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &text;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &sctType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScrollingCombatTextMessage.NativeMethodInfoPtr_CreateLocal_Public_Static_Entity_EntityCommandBuffer_Entity_FixedString512_float3_float3_Entity_Single_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 762712, RefRangeEnd = 762713, XrefRangeStart = 762695, XrefRangeEnd = 762712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity CreateLocal(
      EntityCommandBuffer commandBuffer,
      Entity sctPrefab,
      AssetGuid text,
      float3 position,
      Entity entity,
      float3 color = default (float3),
      float value = 0.0f,
      PrefabGUID sctType = default (PrefabGUID))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sctPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &text;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &sctType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScrollingCombatTextMessage.NativeMethodInfoPtr_CreateLocal_Public_Static_Entity_EntityCommandBuffer_Entity_AssetGuid_float3_Entity_float3_Single_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 762742, RefRangeEnd = 762750, XrefRangeStart = 762713, XrefRangeEnd = 762742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity Create(
      EntityManager entityManager,
      EntityCommandBuffer commandBuffer,
      Entity sctPrefab,
      AssetGuid text,
      float3 position,
      float3 color,
      Entity entity,
      float value = 0.0f,
      PrefabGUID sctType = default (PrefabGUID),
      Entity user = default (Entity))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sctPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &text;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &sctType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &user;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScrollingCombatTextMessage.NativeMethodInfoPtr_Create_Public_Static_Entity_EntityManager_EntityCommandBuffer_Entity_AssetGuid_float3_float3_Entity_Single_PrefabGUID_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 762786, RefRangeEnd = 762797, XrefRangeStart = 762750, XrefRangeEnd = 762786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity Create(
      EntityManager entityManager,
      EntityCommandBuffer commandBuffer,
      Entity sctPrefab,
      float value,
      PrefabGUID sctType,
      float3 position,
      Entity target,
      Entity source,
      PrefabGUID sourceObjectType = default (PrefabGUID),
      float bloodQuality = -1f,
      Entity targetUser = default (Entity),
      Entity sourceUser = default (Entity))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[12];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sctPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &sctType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceObjectType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &bloodQuality;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &targetUser;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceUser;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScrollingCombatTextMessage.NativeMethodInfoPtr_Create_Public_Static_Entity_EntityManager_EntityCommandBuffer_Entity_Single_PrefabGUID_float3_Entity_Entity_PrefabGUID_Single_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 762844, RefRangeEnd = 762845, XrefRangeStart = 762797, XrefRangeEnd = 762844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Entity Create(
      EntityCommandBuffer commandBuffer,
      ComponentDataFromEntity<ControlledBy> getControlledBy,
      Entity sctPrefab,
      float value,
      PrefabGUID sctType,
      float3 position,
      Entity target,
      Entity source,
      PrefabGUID sourceObjectType = default (PrefabGUID),
      float bloodQuality = -1f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getControlledBy;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sctPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &sctType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceObjectType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &bloodQuality;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScrollingCombatTextMessage.NativeMethodInfoPtr_Create_Public_Static_Entity_EntityCommandBuffer_ComponentDataFromEntity_1_ControlledBy_Entity_Single_PrefabGUID_float3_Entity_Entity_PrefabGUID_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ScrollingCombatTextMessage()
    {
      Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ScrollingCombatTextMessage));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr);
      ScrollingCombatTextMessage.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr, nameof (Position));
      ScrollingCombatTextMessage.NativeFieldInfoPtr_OverrideColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr, nameof (OverrideColor));
      ScrollingCombatTextMessage.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr, nameof (Value));
      ScrollingCombatTextMessage.NativeFieldInfoPtr_OverrideLocalizedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr, nameof (OverrideLocalizedText));
      ScrollingCombatTextMessage.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr, nameof (Type));
      ScrollingCombatTextMessage.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr, nameof (Source));
      ScrollingCombatTextMessage.NativeFieldInfoPtr_SourceObjectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr, nameof (SourceObjectType));
      ScrollingCombatTextMessage.NativeFieldInfoPtr_BloodQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr, nameof (BloodQuality));
      ScrollingCombatTextMessage.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr, nameof (Target));
      ScrollingCombatTextMessage.NativeFieldInfoPtr_OverrideText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr, nameof (OverrideText));
      ScrollingCombatTextMessage.NativeFieldInfoPtr_CreateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr, nameof (CreateTime));
      ScrollingCombatTextMessage.NativeFieldInfoPtr_ShowForAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr, nameof (ShowForAll));
      ScrollingCombatTextMessage.NativeMethodInfoPtr_CreateLocal_Public_Static_Entity_EntityManager_Entity_FixedString512_float3_float3_Entity_Single_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr, 100667392);
      ScrollingCombatTextMessage.NativeMethodInfoPtr_CreateLocal_Public_Static_Entity_EntityCommandBuffer_Entity_FixedString512_float3_float3_Entity_Single_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr, 100667393);
      ScrollingCombatTextMessage.NativeMethodInfoPtr_CreateLocal_Public_Static_Entity_EntityCommandBuffer_Entity_AssetGuid_float3_Entity_float3_Single_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr, 100667394);
      ScrollingCombatTextMessage.NativeMethodInfoPtr_Create_Public_Static_Entity_EntityManager_EntityCommandBuffer_Entity_AssetGuid_float3_float3_Entity_Single_PrefabGUID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr, 100667395);
      ScrollingCombatTextMessage.NativeMethodInfoPtr_Create_Public_Static_Entity_EntityManager_EntityCommandBuffer_Entity_Single_PrefabGUID_float3_Entity_Entity_PrefabGUID_Single_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr, 100667396);
      ScrollingCombatTextMessage.NativeMethodInfoPtr_Create_Public_Static_Entity_EntityCommandBuffer_ComponentDataFromEntity_1_ControlledBy_Entity_Single_PrefabGUID_float3_Entity_Entity_PrefabGUID_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr, 100667397);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScrollingCombatTextMessage>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
