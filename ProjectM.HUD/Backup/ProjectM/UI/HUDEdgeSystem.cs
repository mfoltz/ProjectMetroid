// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.HUDEdgeSystem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Terrain;
using StunShared.UI;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM.UI
{
  public class HUDEdgeSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__UIDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedIcons;
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__Elements;
    private static readonly System.IntPtr NativeFieldInfoPtr___PullScreenEdgeIconData_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___PullScreenEdgeIconData_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForPullScreenEdgeIconData_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266330, XrefRangeEnd = 1266353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HUDEdgeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266353, XrefRangeEnd = 1266356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HUDEdgeSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266356, XrefRangeEnd = 1266417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HUDEdgeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HUDEdgeSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266417, XrefRangeEnd = 1266453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HUDEdgeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266453, XrefRangeEnd = 1266472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForPullScreenEdgeIconData_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.NativeMethodInfoPtr___GetEntityQuery_ForPullScreenEdgeIconData_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1266476, RefRangeEnd = 1266477, XrefRangeStart = 1266472, XrefRangeEnd = 1266476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HUDEdgeSystem()
    {
      Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (HUDEdgeSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr);
      HUDEdgeSystem.NativeFieldInfoPtr__UIDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr, nameof (_UIDataSystem));
      HUDEdgeSystem.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr, nameof (_CommonClientDataSystem));
      HUDEdgeSystem.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr, nameof (_GameDataSystem));
      HUDEdgeSystem.NativeFieldInfoPtr__CachedIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr, nameof (_CachedIcons));
      HUDEdgeSystem.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr, nameof (_TerrainManager));
      HUDEdgeSystem.NativeFieldInfoPtr__Elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr, nameof (_Elements));
      HUDEdgeSystem.NativeFieldInfoPtr___PullScreenEdgeIconData_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr, "<>PullScreenEdgeIconData_entityQuery");
      HUDEdgeSystem.NativeFieldInfoPtr___PullScreenEdgeIconData_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr, "<>PullScreenEdgeIconData_profilerMarker");
      HUDEdgeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr, 100667588);
      HUDEdgeSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr, 100667589);
      HUDEdgeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr, 100667590);
      HUDEdgeSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr, 100667591);
      HUDEdgeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr, 100667592);
      HUDEdgeSystem.NativeMethodInfoPtr___GetEntityQuery_ForPullScreenEdgeIconData_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr, 100667593);
      HUDEdgeSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr, 100667594);
    }

    public HUDEdgeSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UIDataSystem _UIDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDEdgeSystem.NativeFieldInfoPtr__UIDataSystem));
        return pointer == System.IntPtr.Zero ? (UIDataSystem) null : new UIDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HUDEdgeSystem.NativeFieldInfoPtr__UIDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDEdgeSystem.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HUDEdgeSystem.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDEdgeSystem.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HUDEdgeSystem.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<ScreenEdgeIconEntry> _CachedIcons
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDEdgeSystem.NativeFieldInfoPtr__CachedIcons));
        return pointer == System.IntPtr.Zero ? (UI_Cache<ScreenEdgeIconEntry>) null : new UI_Cache<ScreenEdgeIconEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HUDEdgeSystem.NativeFieldInfoPtr__CachedIcons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDEdgeSystem.NativeFieldInfoPtr__TerrainManager));
        return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HUDEdgeSystem.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<ScreenEdgeIconEntry.Data> _Elements
    {
      get
      {
        return *(NativeList<ScreenEdgeIconEntry.Data>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDEdgeSystem.NativeFieldInfoPtr__Elements));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDEdgeSystem.NativeFieldInfoPtr__Elements), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ScreenEdgeIconEntry.Data>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __PullScreenEdgeIconData_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDEdgeSystem.NativeFieldInfoPtr___PullScreenEdgeIconData_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDEdgeSystem.NativeFieldInfoPtr___PullScreenEdgeIconData_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __PullScreenEdgeIconData_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDEdgeSystem.NativeFieldInfoPtr___PullScreenEdgeIconData_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HUDEdgeSystem.NativeFieldInfoPtr___PullScreenEdgeIconData_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.HUDEdgeSystem/<>c__DisplayClass8_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass8_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_terrainChunkMetadatas;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerZoneType;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUser;
      private static readonly System.IntPtr NativeFieldInfoPtr_scaleFactor;
      private static readonly System.IntPtr NativeFieldInfoPtr_elements;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Translation_byref_ScreenEdgeIcon_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeHashMap<TerrainChunk, Entity> terrainChunkMetadatas;
      [FieldOffset(24)]
      public WorldZone playerZoneType;
      [FieldOffset(32)]
      public CommonClientDataSystem.LocalUserData localUser;
      [FieldOffset(288)]
      public float scaleFactor;
      [FieldOffset(296)]
      public NativeList<ScreenEdgeIconEntry.Data> elements;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref Translation translation,
        [In] ref ScreenEdgeIcon screenEdgeIcon)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref screenEdgeIcon;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Translation_byref_ScreenEdgeIcon_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_0()
      {
        Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr, "<>c__DisplayClass8_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass8_0>.NativeClassPtr);
        HUDEdgeSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (entityManager));
        HUDEdgeSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_terrainChunkMetadatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (terrainChunkMetadatas));
        HUDEdgeSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_playerZoneType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (playerZoneType));
        HUDEdgeSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_localUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (localUser));
        HUDEdgeSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_scaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (scaleFactor));
        HUDEdgeSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (elements));
        HUDEdgeSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass8_0>.NativeClassPtr, 100667595);
        HUDEdgeSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Translation_byref_ScreenEdgeIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass8_0>.NativeClassPtr, 100667596);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass8_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.HUDEdgeSystem/ProjectM.UI.<>c__DisplayClass_PullScreenEdgeIconData")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_PullScreenEdgeIconData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_terrainChunkMetadatas;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerZoneType;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUser;
      private static readonly System.IntPtr NativeFieldInfoPtr_scaleFactor;
      private static readonly System.IntPtr NativeFieldInfoPtr_elements;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Translation_byref_ScreenEdgeIcon_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HUDEdgeSystem_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeHashMap<TerrainChunk, Entity> terrainChunkMetadatas;
      [FieldOffset(24)]
      public WorldZone playerZoneType;
      [FieldOffset(32)]
      public CommonClientDataSystem.LocalUserData localUser;
      [FieldOffset(288)]
      public float scaleFactor;
      [FieldOffset(296)]
      public NativeList<ScreenEdgeIconEntry.Data> elements;
      [FieldOffset(312)]
      public HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(384)]
      public unsafe HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266285, XrefRangeEnd = 1266303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Translation translation,
        [In] ref ScreenEdgeIcon screenEdgeIcon)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref screenEdgeIcon;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Translation_byref_ScreenEdgeIcon_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1266303, RefRangeEnd = 1266304, XrefRangeStart = 1266303, XrefRangeEnd = 1266303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref HUDEdgeSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1266304, RefRangeEnd = 1266305, XrefRangeStart = 1266304, XrefRangeEnd = 1266304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref HUDEdgeSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266305, XrefRangeEnd = 1266307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1266316, RefRangeEnd = 1266317, XrefRangeStart = 1266307, XrefRangeEnd = 1266316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1266319, RefRangeEnd = 1266320, XrefRangeStart = 1266317, XrefRangeEnd = 1266319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        HUDEdgeSystem componentSystem,
        ref HUDEdgeSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HUDEdgeSystem_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266320, XrefRangeEnd = 1266324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266324, XrefRangeEnd = 1266330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_PullScreenEdgeIconData()
      {
        Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HUDEdgeSystem>.NativeClassPtr, "<>c__DisplayClass_PullScreenEdgeIconData");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr);
        HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, nameof (entityManager));
        HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeFieldInfoPtr_terrainChunkMetadatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, nameof (terrainChunkMetadatas));
        HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeFieldInfoPtr_playerZoneType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, nameof (playerZoneType));
        HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeFieldInfoPtr_localUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, nameof (localUser));
        HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeFieldInfoPtr_scaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, nameof (scaleFactor));
        HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, nameof (elements));
        HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, nameof (_runtimes));
        HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Translation_byref_ScreenEdgeIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, 100667597);
        HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, 100667598);
        HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, 100667599);
        HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, 100667600);
        HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, 100667601);
        HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HUDEdgeSystem_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, 100667602);
        HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, 100667603);
        HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, 100667604);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_screenEdgeIcon;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HUDEdgeSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<ScreenEdgeIcon> forParameter_screenEdgeIcon;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1266201, RefRangeEnd = 1266202, XrefRangeStart = 1266194, XrefRangeEnd = 1266201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(HUDEdgeSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HUDEdgeSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1266209, RefRangeEnd = 1266210, XrefRangeStart = 1266202, XrefRangeEnd = 1266209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_screenEdgeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_screenEdgeIcon));
          HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_HUDEdgeSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders>.NativeClassPtr, 100667605);
          HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders>.NativeClassPtr, 100667606);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_screenEdgeIcon;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<ScreenEdgeIcon>.Runtime runtime_screenEdgeIcon;

          static Runtimes()
          {
            Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_screenEdgeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_screenEdgeIcon));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UI.HUDEdgeSystem/ProjectM.UI.<>c__DisplayClass_PullScreenEdgeIconData/ProjectM.UI.RunWithoutJobSystem_00000F76$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, "RunWithoutJobSystem_00000F76$PostfixBurstDelegate");
          HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667607);
          HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667608);
          HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667609);
          HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667610);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.HUDEdgeSystem/ProjectM.UI.<>c__DisplayClass_PullScreenEdgeIconData/ProjectM.UI.RunWithoutJobSystem_00000F76$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266210, XrefRangeEnd = 1266224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266224, XrefRangeEnd = 1266242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266242, XrefRangeEnd = 1266257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1266284, RefRangeEnd = 1266285, XrefRangeStart = 1266257, XrefRangeEnd = 1266284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData>.NativeClassPtr, "RunWithoutJobSystem_00000F76$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667611);
          HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667612);
          HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667613);
          HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667614);
          HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667616);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(HUDEdgeSystem.__c__DisplayClass_PullScreenEdgeIconData.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
