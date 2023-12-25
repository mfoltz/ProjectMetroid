// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_ModifySpellAbilityCooldownOnGameplayEvent
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
  public class Script_ModifySpellAbilityCooldownOnGameplayEvent : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ModifyCooldown;
    private static readonly IntPtr NativeFieldInfoPtr_ModifyCooldownPercent;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187369, XrefRangeEnd = 1187372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_ModifySpellAbilityCooldownOnGameplayEvent.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_ModifySpellAbilityCooldownOnGameplayEvent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_ModifySpellAbilityCooldownOnGameplayEvent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_ModifySpellAbilityCooldownOnGameplayEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_ModifySpellAbilityCooldownOnGameplayEvent()
    {
      Il2CppClassPointerStore<Script_ModifySpellAbilityCooldownOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_ModifySpellAbilityCooldownOnGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ModifySpellAbilityCooldownOnGameplayEvent>.NativeClassPtr);
      Script_ModifySpellAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_ModifyCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ModifySpellAbilityCooldownOnGameplayEvent>.NativeClassPtr, nameof (ModifyCooldown));
      Script_ModifySpellAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_ModifyCooldownPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ModifySpellAbilityCooldownOnGameplayEvent>.NativeClassPtr, nameof (ModifyCooldownPercent));
      Script_ModifySpellAbilityCooldownOnGameplayEvent.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ModifySpellAbilityCooldownOnGameplayEvent>.NativeClassPtr, 100664624);
      Script_ModifySpellAbilityCooldownOnGameplayEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ModifySpellAbilityCooldownOnGameplayEvent>.NativeClassPtr, 100664625);
    }

    public Script_ModifySpellAbilityCooldownOnGameplayEvent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float ModifyCooldown
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifySpellAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_ModifyCooldown));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifySpellAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_ModifyCooldown)) = value;
      }
    }

    public unsafe float ModifyCooldownPercent
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifySpellAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_ModifyCooldownPercent));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ModifySpellAbilityCooldownOnGameplayEvent.NativeFieldInfoPtr_ModifyCooldownPercent)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_ModifySpellAbilityCooldownOnGameplayEvent_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0;
      private static readonly IntPtr NativeMethodInfoPtr_TryGetGroupSlots_Private_Static_Boolean_byref_ServerGameManager_byref_SelfServer_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187307, XrefRangeEnd = 1187361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void ModifySpellAbilityCooldownOnGameplayEvent(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref GameplayEvent gameplayEvent)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref gameplayEvent;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_ModifySpellAbilityCooldownOnGameplayEvent.Server.NativeMethodInfoPtr_ModifySpellAbilityCooldownOnGameplayEvent_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187361, XrefRangeEnd = 1187369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool TryGetGroupSlots(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        out DynamicBuffer<AbilityGroupSlotBuffer> result)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref result;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_ModifySpellAbilityCooldownOnGameplayEvent.Server.NativeMethodInfoPtr_TryGetGroupSlots_Private_Static_Boolean_byref_ServerGameManager_byref_SelfServer_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_ModifySpellAbilityCooldownOnGameplayEvent.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_ModifySpellAbilityCooldownOnGameplayEvent.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_ModifySpellAbilityCooldownOnGameplayEvent.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_ModifySpellAbilityCooldownOnGameplayEvent>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ModifySpellAbilityCooldownOnGameplayEvent.Server>.NativeClassPtr);
        Script_ModifySpellAbilityCooldownOnGameplayEvent.Server.NativeMethodInfoPtr_ModifySpellAbilityCooldownOnGameplayEvent_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ModifySpellAbilityCooldownOnGameplayEvent.Server>.NativeClassPtr, 100664626);
        Script_ModifySpellAbilityCooldownOnGameplayEvent.Server.NativeMethodInfoPtr_TryGetGroupSlots_Private_Static_Boolean_byref_ServerGameManager_byref_SelfServer_byref_DynamicBuffer_1_AbilityGroupSlotBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ModifySpellAbilityCooldownOnGameplayEvent.Server>.NativeClassPtr, 100664627);
        Script_ModifySpellAbilityCooldownOnGameplayEvent.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ModifySpellAbilityCooldownOnGameplayEvent.Server>.NativeClassPtr, 100664628);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
