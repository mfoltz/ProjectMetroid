// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_PreCast_Roll
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_PreCast_Roll : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_InputIsPressed;
    private static readonly IntPtr NativeFieldInfoPtr_RollAbility;
    private static readonly IntPtr NativeFieldInfoPtr_JumpAbility;
    private static readonly IntPtr NativeFieldInfoPtr_JumpTriggerTimer;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176173, XrefRangeEnd = 1176178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_PreCast_Roll.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_PreCast_Roll()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_PreCast_Roll>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_PreCast_Roll.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_PreCast_Roll()
    {
      Il2CppClassPointerStore<Script_PreCast_Roll>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_PreCast_Roll));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_PreCast_Roll>.NativeClassPtr);
      Script_PreCast_Roll.NativeFieldInfoPtr_InputIsPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_PreCast_Roll>.NativeClassPtr, nameof (InputIsPressed));
      Script_PreCast_Roll.NativeFieldInfoPtr_RollAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_PreCast_Roll>.NativeClassPtr, nameof (RollAbility));
      Script_PreCast_Roll.NativeFieldInfoPtr_JumpAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_PreCast_Roll>.NativeClassPtr, nameof (JumpAbility));
      Script_PreCast_Roll.NativeFieldInfoPtr_JumpTriggerTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_PreCast_Roll>.NativeClassPtr, nameof (JumpTriggerTimer));
      Script_PreCast_Roll.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_PreCast_Roll>.NativeClassPtr, 100663511);
      Script_PreCast_Roll.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_PreCast_Roll>.NativeClassPtr, 100663512);
    }

    public Script_PreCast_Roll(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool InputIsPressed
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_PreCast_Roll.NativeFieldInfoPtr_InputIsPressed));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_PreCast_Roll.NativeFieldInfoPtr_InputIsPressed)) = value;
      }
    }

    public unsafe PrefabGuidComponent RollAbility
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_PreCast_Roll.NativeFieldInfoPtr_RollAbility));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_PreCast_Roll.NativeFieldInfoPtr_RollAbility), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent JumpAbility
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_PreCast_Roll.NativeFieldInfoPtr_JumpAbility));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_PreCast_Roll.NativeFieldInfoPtr_JumpAbility), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float JumpTriggerTimer
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_PreCast_Roll.NativeFieldInfoPtr_JumpTriggerTimer));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_PreCast_Roll.NativeFieldInfoPtr_JumpTriggerTimer)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_AbilityCastStarted_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastStartedData_0;
      private static readonly IntPtr NativeMethodInfoPtr_AbilityCastUpdate_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastUpdateData_0;
      private static readonly IntPtr NativeMethodInfoPtr_TryTriggerJump_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176147, XrefRangeEnd = 1176162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(Script_PreCast_Roll.Server.NativeMethodInfoPtr_AbilityCastStarted_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastStartedData_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176162, XrefRangeEnd = 1176165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void AbilityCastUpdate(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastUpdateData data)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref data;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_PreCast_Roll.Server.NativeMethodInfoPtr_AbilityCastUpdate_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastUpdateData_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176165, XrefRangeEnd = 1176173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void TryTriggerJump(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_PreCast_Roll.Server.NativeMethodInfoPtr_TryTriggerJump_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_PreCast_Roll.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_PreCast_Roll.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_PreCast_Roll.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_PreCast_Roll>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_PreCast_Roll.Server>.NativeClassPtr);
        Script_PreCast_Roll.Server.NativeMethodInfoPtr_AbilityCastStarted_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastStartedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_PreCast_Roll.Server>.NativeClassPtr, 100663513);
        Script_PreCast_Roll.Server.NativeMethodInfoPtr_AbilityCastUpdate_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastUpdateData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_PreCast_Roll.Server>.NativeClassPtr, 100663514);
        Script_PreCast_Roll.Server.NativeMethodInfoPtr_TryTriggerJump_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_PreCast_Roll.Server>.NativeClassPtr, 100663515);
        Script_PreCast_Roll.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_PreCast_Roll.Server>.NativeClassPtr, 100663516);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
