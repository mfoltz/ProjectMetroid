// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Fly_CheckLanding
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_Fly_CheckLanding : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_OnLocationFoundEventId;
    private static readonly IntPtr NativeFieldInfoPtr_LandingBlocked;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175351, XrefRangeEnd = 1175355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_Fly_CheckLanding.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_Fly_CheckLanding()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Fly_CheckLanding>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_Fly_CheckLanding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_Fly_CheckLanding()
    {
      Il2CppClassPointerStore<Script_Fly_CheckLanding>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Fly_CheckLanding));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Fly_CheckLanding>.NativeClassPtr);
      Script_Fly_CheckLanding.NativeFieldInfoPtr_OnLocationFoundEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Fly_CheckLanding>.NativeClassPtr, nameof (OnLocationFoundEventId));
      Script_Fly_CheckLanding.NativeFieldInfoPtr_LandingBlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Fly_CheckLanding>.NativeClassPtr, nameof (LandingBlocked));
      Script_Fly_CheckLanding.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Fly_CheckLanding>.NativeClassPtr, 100663420);
      Script_Fly_CheckLanding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Fly_CheckLanding>.NativeClassPtr, 100663421);
    }

    public Script_Fly_CheckLanding(IntPtr pointer)
      : base(pointer)
    {
    }

    public GameplayEventIdSource OnLocationFoundEventId
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Fly_CheckLanding.NativeFieldInfoPtr_OnLocationFoundEventId);
        return new GameplayEventIdSource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Fly_CheckLanding.NativeFieldInfoPtr_OnLocationFoundEventId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe LocalizationKey LandingBlocked
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Fly_CheckLanding.NativeFieldInfoPtr_LandingBlocked));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Fly_CheckLanding.NativeFieldInfoPtr_LandingBlocked)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_AbilityCastStarted_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastStartedData_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175328, XrefRangeEnd = 1175351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void AbilityCastStarted(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastStartedData data)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref data;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Fly_CheckLanding.Server.NativeMethodInfoPtr_AbilityCastStarted_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastStartedData_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Fly_CheckLanding.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Fly_CheckLanding.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_Fly_CheckLanding.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_Fly_CheckLanding>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Fly_CheckLanding.Server>.NativeClassPtr);
        Script_Fly_CheckLanding.Server.NativeMethodInfoPtr_AbilityCastStarted_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastStartedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Fly_CheckLanding.Server>.NativeClassPtr, 100663422);
        Script_Fly_CheckLanding.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Fly_CheckLanding.Server>.NativeClassPtr, 100663423);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
