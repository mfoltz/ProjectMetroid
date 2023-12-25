// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerGameSettingsSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class ServerGameSettingsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Settings;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerBalanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__WasCastlePvPEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr__WasVampirePvPEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr___SendEventToAllUsers_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SendEventToAllUsers_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_11;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Settings_Public_get_ServerGameSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendEventToAllUsers_Private_Void_ToggleType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSendEventToAllUsers_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    public unsafe ServerGameSettings Settings
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameSettingsSystem.NativeMethodInfoPtr_get_Settings_Public_get_ServerGameSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ServerGameSettings) null : new ServerGameSettings(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985899, XrefRangeEnd = 986020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerGameSettingsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986020, XrefRangeEnd = 986030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerGameSettingsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 986040, RefRangeEnd = 986044, XrefRangeStart = 986030, XrefRangeEnd = 986040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendEventToAllUsers(PvPToggleEvent.ToggleType type)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &type;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameSettingsSystem.NativeMethodInfoPtr_SendEventToAllUsers_Private_Void_ToggleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerGameSettingsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerGameSettingsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerGameSettingsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986044, XrefRangeEnd = 986071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerGameSettingsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986071, XrefRangeEnd = 986087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSendEventToAllUsers_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameSettingsSystem.NativeMethodInfoPtr___GetEntityQuery_ForSendEventToAllUsers_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ServerGameSettingsSystem()
    {
      Il2CppClassPointerStore<ServerGameSettingsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServerGameSettingsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerGameSettingsSystem>.NativeClassPtr);
      ServerGameSettingsSystem.NativeFieldInfoPtr__Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsSystem>.NativeClassPtr, nameof (_Settings));
      ServerGameSettingsSystem.NativeFieldInfoPtr__ServerBalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsSystem>.NativeClassPtr, nameof (_ServerBalanceSettings));
      ServerGameSettingsSystem.NativeFieldInfoPtr__WasCastlePvPEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsSystem>.NativeClassPtr, nameof (_WasCastlePvPEnabled));
      ServerGameSettingsSystem.NativeFieldInfoPtr__WasVampirePvPEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsSystem>.NativeClassPtr, nameof (_WasVampirePvPEnabled));
      ServerGameSettingsSystem.NativeFieldInfoPtr___SendEventToAllUsers_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsSystem>.NativeClassPtr, "<>SendEventToAllUsers_LambdaJob0_entityQuery");
      ServerGameSettingsSystem.NativeFieldInfoPtr___SendEventToAllUsers_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsSystem>.NativeClassPtr, "<>SendEventToAllUsers_LambdaJob0_profilerMarker");
      ServerGameSettingsSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerRuntimeSettings_11));
      ServerGameSettingsSystem.NativeMethodInfoPtr_get_Settings_Public_get_ServerGameSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsSystem>.NativeClassPtr, 100676069);
      ServerGameSettingsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsSystem>.NativeClassPtr, 100676070);
      ServerGameSettingsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsSystem>.NativeClassPtr, 100676071);
      ServerGameSettingsSystem.NativeMethodInfoPtr_SendEventToAllUsers_Private_Void_ToggleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsSystem>.NativeClassPtr, 100676072);
      ServerGameSettingsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsSystem>.NativeClassPtr, 100676073);
      ServerGameSettingsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsSystem>.NativeClassPtr, 100676074);
      ServerGameSettingsSystem.NativeMethodInfoPtr___GetEntityQuery_ForSendEventToAllUsers_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsSystem>.NativeClassPtr, 100676075);
    }

    public ServerGameSettingsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ServerGameSettings _Settings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.NativeFieldInfoPtr__Settings));
        return pointer == System.IntPtr.Zero ? (ServerGameSettings) null : new ServerGameSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.NativeFieldInfoPtr__Settings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<ServerGameBalanceSettings> _ServerBalanceSettings
    {
      get
      {
        return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.NativeFieldInfoPtr__ServerBalanceSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.NativeFieldInfoPtr__ServerBalanceSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe bool _WasCastlePvPEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.NativeFieldInfoPtr__WasCastlePvPEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.NativeFieldInfoPtr__WasCastlePvPEnabled)) = value;
      }
    }

    public unsafe bool _WasVampirePvPEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.NativeFieldInfoPtr__WasVampirePvPEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.NativeFieldInfoPtr__WasVampirePvPEnabled)) = value;
      }
    }

    public unsafe EntityQuery __SendEventToAllUsers_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.NativeFieldInfoPtr___SendEventToAllUsers_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.NativeFieldInfoPtr___SendEventToAllUsers_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SendEventToAllUsers_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.NativeFieldInfoPtr___SendEventToAllUsers_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.NativeFieldInfoPtr___SendEventToAllUsers_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerRuntimeSettings_11
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_11));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_11)) = value;
      }
    }

    [ObfuscatedName("ProjectM.ServerGameSettingsSystem/<>c__DisplayClass8_0")]
    public sealed class __c__DisplayClass8_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_type;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SendEventToAllUsers_b__0_Internal_Void_byref_User_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass8_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerGameSettingsSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _SendEventToAllUsers_b__0([In] ref User user)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref user;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerGameSettingsSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__SendEventToAllUsers_b__0_Internal_Void_byref_User_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_0()
      {
        Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerGameSettingsSystem>.NativeClassPtr, "<>c__DisplayClass8_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass8_0>.NativeClassPtr);
        ServerGameSettingsSystem.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
        ServerGameSettingsSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (type));
        ServerGameSettingsSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass8_0>.NativeClassPtr, 100676076);
        ServerGameSettingsSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__SendEventToAllUsers_b__0_Internal_Void_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass8_0>.NativeClassPtr, 100676077);
      }

      public __c__DisplayClass8_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass8_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass8_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass8_0>.NativeClassPtr, data));
      }

      public unsafe ServerGameSettingsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerGameSettingsSystem) null : new ServerGameSettingsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PvPToggleEvent.ToggleType type
      {
        get
        {
          return *(PvPToggleEvent.ToggleType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_type));
        }
        [param: In] set
        {
          *(PvPToggleEvent.ToggleType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_type)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.ServerGameSettingsSystem/ProjectM.<>c__DisplayClass_SendEventToAllUsers_LambdaJob0")]
    public sealed class __c__DisplayClass_SendEventToAllUsers_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_type;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerGameSettingsSystem_byref___c__DisplayClass8_0_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985867, XrefRangeEnd = 985872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref User user)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref user;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985872, XrefRangeEnd = 985873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerGameSettingsSystem.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 985874, RefRangeEnd = 985876, XrefRangeStart = 985873, XrefRangeEnd = 985874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerGameSettingsSystem.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985876, XrefRangeEnd = 985889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 985895, RefRangeEnd = 985896, XrefRangeStart = 985889, XrefRangeEnd = 985895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 985897, RefRangeEnd = 985899, XrefRangeStart = 985896, XrefRangeEnd = 985897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerGameSettingsSystem componentSystem,
        ref ServerGameSettingsSystem.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerGameSettingsSystem_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SendEventToAllUsers_LambdaJob0()
      {
        Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerGameSettingsSystem>.NativeClassPtr, "<>c__DisplayClass_SendEventToAllUsers_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0>.NativeClassPtr);
        ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0>.NativeClassPtr, "<>4__this");
        ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0>.NativeClassPtr, nameof (type));
        ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0>.NativeClassPtr, 100676078);
        ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0>.NativeClassPtr, 100676079);
        ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0>.NativeClassPtr, 100676080);
        ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0>.NativeClassPtr, 100676082);
        ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0>.NativeClassPtr, 100676083);
        ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerGameSettingsSystem_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0>.NativeClassPtr, 100676084);
      }

      public __c__DisplayClass_SendEventToAllUsers_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_SendEventToAllUsers_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe ServerGameSettingsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServerGameSettingsSystem) null : new ServerGameSettingsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PvPToggleEvent.ToggleType type
      {
        get
        {
          return *(PvPToggleEvent.ToggleType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeFieldInfoPtr_type));
        }
        [param: In] set
        {
          *(PvPToggleEvent.ToggleType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeFieldInfoPtr_type)) = value;
        }
      }

      public unsafe ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerGameSettingsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985859, XrefRangeEnd = 985862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerGameSettingsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerGameSettingsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 985866, RefRangeEnd = 985867, XrefRangeStart = 985862, XrefRangeEnd = 985866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerGameSettingsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100676085);
          ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100676086);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<User>.StructuralChangeRuntime runtime_user;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerGameSettingsSystem.__c__DisplayClass_SendEventToAllUsers_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
