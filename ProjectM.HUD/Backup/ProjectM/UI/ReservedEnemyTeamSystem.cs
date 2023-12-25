// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ReservedEnemyTeamSystem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.UI
{
  public class ReservedEnemyTeamSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ReservedEnemyColorIndexArray;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___ReservedEnemyColorIndex_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ReservedEnemyColorIndex_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UnreservedEnemyColorIndex_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForReservedEnemyColorIndex_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219212, XrefRangeEnd = 1219220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReservedEnemyTeamSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219220, XrefRangeEnd = 1219223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReservedEnemyTeamSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219223, XrefRangeEnd = 1219252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReservedEnemyTeamSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReservedEnemyTeamSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219252, XrefRangeEnd = 1219286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReservedEnemyTeamSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1219308, RefRangeEnd = 1219309, XrefRangeStart = 1219286, XrefRangeEnd = 1219308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForReservedEnemyColorIndex_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.NativeMethodInfoPtr___GetEntityQuery_ForReservedEnemyColorIndex_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1219313, RefRangeEnd = 1219314, XrefRangeStart = 1219309, XrefRangeEnd = 1219313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1219318, RefRangeEnd = 1219319, XrefRangeStart = 1219314, XrefRangeEnd = 1219318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReservedEnemyTeamSystem()
    {
      Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ReservedEnemyTeamSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr);
      ReservedEnemyTeamSystem.NativeFieldInfoPtr__ReservedEnemyColorIndexArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr, nameof (_ReservedEnemyColorIndexArray));
      ReservedEnemyTeamSystem.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr, nameof (_CommonClientDataSystem));
      ReservedEnemyTeamSystem.NativeFieldInfoPtr___ReservedEnemyColorIndex_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr, "<>ReservedEnemyColorIndex_entityQuery");
      ReservedEnemyTeamSystem.NativeFieldInfoPtr___ReservedEnemyColorIndex_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr, "<>ReservedEnemyColorIndex_profilerMarker");
      ReservedEnemyTeamSystem.NativeFieldInfoPtr___UnreservedEnemyColorIndex_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr, "<>UnreservedEnemyColorIndex_profilerMarker");
      ReservedEnemyTeamSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr, 100664450);
      ReservedEnemyTeamSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr, 100664451);
      ReservedEnemyTeamSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr, 100664452);
      ReservedEnemyTeamSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr, 100664453);
      ReservedEnemyTeamSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr, 100664454);
      ReservedEnemyTeamSystem.NativeMethodInfoPtr___GetEntityQuery_ForReservedEnemyColorIndex_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr, 100664455);
      ReservedEnemyTeamSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr, 100664456);
      ReservedEnemyTeamSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr, 100664457);
    }

    public ReservedEnemyTeamSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeArray<ReservedEnemyTeamSystem.ReservedEnemyColorIndex> _ReservedEnemyColorIndexArray
    {
      get
      {
        return *(NativeArray<ReservedEnemyTeamSystem.ReservedEnemyColorIndex>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReservedEnemyTeamSystem.NativeFieldInfoPtr__ReservedEnemyColorIndexArray));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReservedEnemyTeamSystem.NativeFieldInfoPtr__ReservedEnemyColorIndexArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ReservedEnemyTeamSystem.ReservedEnemyColorIndex>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReservedEnemyTeamSystem.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReservedEnemyTeamSystem.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __ReservedEnemyColorIndex_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReservedEnemyTeamSystem.NativeFieldInfoPtr___ReservedEnemyColorIndex_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReservedEnemyTeamSystem.NativeFieldInfoPtr___ReservedEnemyColorIndex_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ReservedEnemyColorIndex_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReservedEnemyTeamSystem.NativeFieldInfoPtr___ReservedEnemyColorIndex_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReservedEnemyTeamSystem.NativeFieldInfoPtr___ReservedEnemyColorIndex_profilerMarker)) = value;
      }
    }

    public unsafe ProfilerMarker __UnreservedEnemyColorIndex_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReservedEnemyTeamSystem.NativeFieldInfoPtr___UnreservedEnemyColorIndex_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReservedEnemyTeamSystem.NativeFieldInfoPtr___UnreservedEnemyColorIndex_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ReservedEnemyColorIndex
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ReservedTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_Team;
      private static readonly System.IntPtr NativeFieldInfoPtr_Used;
      [FieldOffset(0)]
      public float ReservedTime;
      [FieldOffset(4)]
      public Team Team;
      [FieldOffset(12)]
      public bool Used;

      static ReservedEnemyColorIndex()
      {
        Il2CppClassPointerStore<ReservedEnemyTeamSystem.ReservedEnemyColorIndex>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr, nameof (ReservedEnemyColorIndex));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReservedEnemyTeamSystem.ReservedEnemyColorIndex>.NativeClassPtr);
        ReservedEnemyTeamSystem.ReservedEnemyColorIndex.NativeFieldInfoPtr_ReservedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.ReservedEnemyColorIndex>.NativeClassPtr, nameof (ReservedTime));
        ReservedEnemyTeamSystem.ReservedEnemyColorIndex.NativeFieldInfoPtr_Team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.ReservedEnemyColorIndex>.NativeClassPtr, nameof (Team));
        ReservedEnemyTeamSystem.ReservedEnemyColorIndex.NativeFieldInfoPtr_Used = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.ReservedEnemyColorIndex>.NativeClassPtr, nameof (Used));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReservedEnemyTeamSystem.ReservedEnemyColorIndex>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.ReservedEnemyTeamSystem/<>c__DisplayClass5_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass5_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_reservedEnemyColorIndexArray;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentTime;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_CharacterHUD_byref_Team_byref_CheckOnScreen_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_0;
      [FieldOffset(0)]
      public Team localPlayerTeam;
      [FieldOffset(8)]
      public NativeArray<ReservedEnemyTeamSystem.ReservedEnemyColorIndex> reservedEnemyColorIndexArray;
      [FieldOffset(24)]
      public float currentTime;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass5_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        ref CharacterHUD hud,
        [In] ref Team team,
        [In] ref CheckOnScreen checkOnScreen)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref hud;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref checkOnScreen;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_CharacterHUD_byref_Team_byref_CheckOnScreen_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass5_0()
      {
        Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr, "<>c__DisplayClass5_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass5_0>.NativeClassPtr);
        ReservedEnemyTeamSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_localPlayerTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (localPlayerTeam));
        ReservedEnemyTeamSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_reservedEnemyColorIndexArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (reservedEnemyColorIndexArray));
        ReservedEnemyTeamSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (currentTime));
        ReservedEnemyTeamSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass5_0>.NativeClassPtr, 100664458);
        ReservedEnemyTeamSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_CharacterHUD_byref_Team_byref_CheckOnScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass5_0>.NativeClassPtr, 100664459);
        ReservedEnemyTeamSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass5_0>.NativeClassPtr, 100664460);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass5_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.ReservedEnemyTeamSystem/ProjectM.UI.<>c__DisplayClass_ReservedEnemyColorIndex")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ReservedEnemyColorIndex
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_reservedEnemyColorIndexArray;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CharacterHUD_byref_Team_byref_CheckOnScreen_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReservedEnemyTeamSystem_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public Team localPlayerTeam;
      [FieldOffset(8)]
      public NativeArray<ReservedEnemyTeamSystem.ReservedEnemyColorIndex> reservedEnemyColorIndexArray;
      [FieldOffset(24)]
      public float currentTime;
      [FieldOffset(32)]
      public ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(128)]
      public unsafe ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1219040, RefRangeEnd = 1219041, XrefRangeStart = 1219030, XrefRangeEnd = 1219040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref CharacterHUD hud,
        [In] ref Team team,
        [In] ref CheckOnScreen checkOnScreen)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref hud;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref checkOnScreen;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CharacterHUD_byref_Team_byref_CheckOnScreen_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1219041, RefRangeEnd = 1219042, XrefRangeStart = 1219041, XrefRangeEnd = 1219041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ReservedEnemyTeamSystem.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1219042, RefRangeEnd = 1219043, XrefRangeStart = 1219042, XrefRangeEnd = 1219042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ReservedEnemyTeamSystem.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219043, XrefRangeEnd = 1219045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1219056, RefRangeEnd = 1219057, XrefRangeStart = 1219045, XrefRangeEnd = 1219056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1219059, RefRangeEnd = 1219060, XrefRangeStart = 1219057, XrefRangeEnd = 1219059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ReservedEnemyTeamSystem componentSystem,
        ref ReservedEnemyTeamSystem.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReservedEnemyTeamSystem_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219060, XrefRangeEnd = 1219064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219064, XrefRangeEnd = 1219070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ReservedEnemyColorIndex()
      {
        Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr, "<>c__DisplayClass_ReservedEnemyColorIndex");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr);
        ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeFieldInfoPtr_localPlayerTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr, nameof (localPlayerTeam));
        ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeFieldInfoPtr_reservedEnemyColorIndexArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr, nameof (reservedEnemyColorIndexArray));
        ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr, nameof (currentTime));
        ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr, nameof (_runtimes));
        ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_CharacterHUD_byref_Team_byref_CheckOnScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr, 100664461);
        ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr, 100664462);
        ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr, 100664463);
        ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr, 100664464);
        ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr, 100664465);
        ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReservedEnemyTeamSystem_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr, 100664466);
        ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr, 100664467);
        ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr, 100664468);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_hud;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_team;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_checkOnScreen;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReservedEnemyTeamSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<CharacterHUD> forParameter_hud;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<Team> forParameter_team;
        [FieldOffset(64)]
        public LambdaParameterValueProvider_IComponentData<CheckOnScreen> forParameter_checkOnScreen;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1218944, RefRangeEnd = 1218945, XrefRangeStart = 1218935, XrefRangeEnd = 1218944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ReservedEnemyTeamSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReservedEnemyTeamSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1218954, RefRangeEnd = 1218955, XrefRangeStart = 1218945, XrefRangeEnd = 1218954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_hud = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_hud));
          ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_team));
          ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_checkOnScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_checkOnScreen));
          ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReservedEnemyTeamSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders>.NativeClassPtr, 100664469);
          ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders>.NativeClassPtr, 100664470);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_hud;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_team;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_checkOnScreen;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<CharacterHUD>.Runtime runtime_hud;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Team>.Runtime runtime_team;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<CheckOnScreen>.Runtime runtime_checkOnScreen;

          static Runtimes()
          {
            Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hud = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_hud));
            ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_team));
            ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_checkOnScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_checkOnScreen));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UI.ReservedEnemyTeamSystem/ProjectM.UI.<>c__DisplayClass_ReservedEnemyColorIndex/ProjectM.UI.RunWithoutJobSystem_000003E9$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr, "RunWithoutJobSystem_000003E9$PostfixBurstDelegate");
          ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664471);
          ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664472);
          ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664473);
          ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664474);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.ReservedEnemyTeamSystem/ProjectM.UI.<>c__DisplayClass_ReservedEnemyColorIndex/ProjectM.UI.RunWithoutJobSystem_000003E9$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218955, XrefRangeEnd = 1218969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218969, XrefRangeEnd = 1218987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218987, XrefRangeEnd = 1219002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1219029, RefRangeEnd = 1219030, XrefRangeStart = 1219002, XrefRangeEnd = 1219029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex>.NativeClassPtr, "RunWithoutJobSystem_000003E9$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664475);
          ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664476);
          ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664477);
          ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664478);
          ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664480);
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
            IL2CPP.il2cpp_field_static_get_value(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ReservedEnemyTeamSystem.__c__DisplayClass_ReservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.ReservedEnemyTeamSystem/ProjectM.UI.<>c__DisplayClass_UnreservedEnemyColorIndex")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UnreservedEnemyColorIndex
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_reservedEnemyColorIndexArray;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReservedEnemyTeamSystem_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0;
      [FieldOffset(0)]
      public NativeArray<ReservedEnemyTeamSystem.ReservedEnemyColorIndex> reservedEnemyColorIndexArray;
      [FieldOffset(16)]
      public float currentTime;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1219145, RefRangeEnd = 1219146, XrefRangeStart = 1219145, XrefRangeEnd = 1219145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1219146, RefRangeEnd = 1219147, XrefRangeStart = 1219146, XrefRangeEnd = 1219146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ReservedEnemyTeamSystem.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1219147, RefRangeEnd = 1219148, XrefRangeStart = 1219147, XrefRangeEnd = 1219147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ReservedEnemyTeamSystem.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1219149, RefRangeEnd = 1219150, XrefRangeStart = 1219148, XrefRangeEnd = 1219149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1219151, RefRangeEnd = 1219152, XrefRangeStart = 1219150, XrefRangeEnd = 1219151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ReservedEnemyTeamSystem componentSystem,
        ref ReservedEnemyTeamSystem.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReservedEnemyTeamSystem_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219152, XrefRangeEnd = 1219156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1219211, RefRangeEnd = 1219212, XrefRangeStart = 1219156, XrefRangeEnd = 1219211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_Void_0(void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UnreservedEnemyColorIndex()
      {
        Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReservedEnemyTeamSystem>.NativeClassPtr, "<>c__DisplayClass_UnreservedEnemyColorIndex");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex>.NativeClassPtr);
        ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeFieldInfoPtr_reservedEnemyColorIndexArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex>.NativeClassPtr, nameof (reservedEnemyColorIndexArray));
        ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex>.NativeClassPtr, nameof (currentTime));
        ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex>.NativeClassPtr, 100664481);
        ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex>.NativeClassPtr, 100664482);
        ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex>.NativeClassPtr, 100664483);
        ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex>.NativeClassPtr, 100664484);
        ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReservedEnemyTeamSystem_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex>.NativeClassPtr, 100664485);
        ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex>.NativeClassPtr, 100664486);
        ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex>.NativeClassPtr, 100664487);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [ObfuscatedName("ProjectM.UI.ReservedEnemyTeamSystem/ProjectM.UI.<>c__DisplayClass_UnreservedEnemyColorIndex/ProjectM.UI.RunWithoutJobSystem_000003F1$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 506273, RefRangeEnd = 506274, XrefRangeStart = 506273, XrefRangeEnd = 506274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(4)]
        [CachedScanResults(RefRangeStart = 43644, RefRangeEnd = 43648, XrefRangeStart = 43644, XrefRangeEnd = 43648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          void* jobData,
          Il2CppSystem.AsyncCallback _param2,
          Il2CppSystem.Object _param3)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param2);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObUnique()
        {
          Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex>.NativeClassPtr, "RunWithoutJobSystem_000003F1$PostfixBurstDelegate");
          ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100664488);
          ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100664489);
          ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100664490);
          ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.MulticastDelegateNPublicSealedVoObUnique>.NativeClassPtr, 100664491);
        }

        public MulticastDelegateNPublicSealedVoObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.ReservedEnemyTeamSystem/ProjectM.UI.<>c__DisplayClass_UnreservedEnemyColorIndex/ProjectM.UI.RunWithoutJobSystem_000003F1$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219070, XrefRangeEnd = 1219084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219084, XrefRangeEnd = 1219102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219102, XrefRangeEnd = 1219117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1219144, RefRangeEnd = 1219145, XrefRangeStart = 1219117, XrefRangeEnd = 1219144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex>.NativeClassPtr, "RunWithoutJobSystem_000003F1$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664492);
          ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664493);
          ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664494);
          ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664495);
          ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664497);
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
            IL2CPP.il2cpp_field_static_get_value(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ReservedEnemyTeamSystem.__c__DisplayClass_UnreservedEnemyColorIndex.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
