﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_SetBehaviourTreeStateOnGameplayEvent
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
  public class Script_SetBehaviourTreeStateOnGameplayEvent : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_State;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187437, XrefRangeEnd = 1187440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_SetBehaviourTreeStateOnGameplayEvent.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_SetBehaviourTreeStateOnGameplayEvent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_SetBehaviourTreeStateOnGameplayEvent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_SetBehaviourTreeStateOnGameplayEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_SetBehaviourTreeStateOnGameplayEvent()
    {
      Il2CppClassPointerStore<Script_SetBehaviourTreeStateOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_SetBehaviourTreeStateOnGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SetBehaviourTreeStateOnGameplayEvent>.NativeClassPtr);
      Script_SetBehaviourTreeStateOnGameplayEvent.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SetBehaviourTreeStateOnGameplayEvent>.NativeClassPtr, nameof (State));
      Script_SetBehaviourTreeStateOnGameplayEvent.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SetBehaviourTreeStateOnGameplayEvent>.NativeClassPtr, 100664634);
      Script_SetBehaviourTreeStateOnGameplayEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SetBehaviourTreeStateOnGameplayEvent>.NativeClassPtr, 100664635);
    }

    public Script_SetBehaviourTreeStateOnGameplayEvent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GenericEnemyState State
    {
      get
      {
        return *(GenericEnemyState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SetBehaviourTreeStateOnGameplayEvent.NativeFieldInfoPtr_State));
      }
      [param: In] set
      {
        *(GenericEnemyState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SetBehaviourTreeStateOnGameplayEvent.NativeFieldInfoPtr_State)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_OnGameplayEvent_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187430, XrefRangeEnd = 1187437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void OnGameplayEvent(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref GameplayEvent gameplayEvent)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref gameplayEvent;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_SetBehaviourTreeStateOnGameplayEvent.Server.NativeMethodInfoPtr_OnGameplayEvent_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_SetBehaviourTreeStateOnGameplayEvent.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_SetBehaviourTreeStateOnGameplayEvent.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_SetBehaviourTreeStateOnGameplayEvent.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_SetBehaviourTreeStateOnGameplayEvent>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SetBehaviourTreeStateOnGameplayEvent.Server>.NativeClassPtr);
        Script_SetBehaviourTreeStateOnGameplayEvent.Server.NativeMethodInfoPtr_OnGameplayEvent_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SetBehaviourTreeStateOnGameplayEvent.Server>.NativeClassPtr, 100664636);
        Script_SetBehaviourTreeStateOnGameplayEvent.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SetBehaviourTreeStateOnGameplayEvent.Server>.NativeClassPtr, 100664637);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}