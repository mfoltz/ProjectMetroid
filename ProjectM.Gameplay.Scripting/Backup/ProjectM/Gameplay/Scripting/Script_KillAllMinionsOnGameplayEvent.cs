﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_KillAllMinionsOnGameplayEvent
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_KillAllMinionsOnGameplayEvent : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_KillAllMinionsOnGameplayEvent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_KillAllMinionsOnGameplayEvent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_KillAllMinionsOnGameplayEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_KillAllMinionsOnGameplayEvent()
    {
      Il2CppClassPointerStore<Script_KillAllMinionsOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_KillAllMinionsOnGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_KillAllMinionsOnGameplayEvent>.NativeClassPtr);
      Script_KillAllMinionsOnGameplayEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_KillAllMinionsOnGameplayEvent>.NativeClassPtr, 100664615);
    }

    public Script_KillAllMinionsOnGameplayEvent(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_OnGameplayEvent_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187212, XrefRangeEnd = 1187222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(Script_KillAllMinionsOnGameplayEvent.Server.NativeMethodInfoPtr_OnGameplayEvent_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_KillAllMinionsOnGameplayEvent.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_KillAllMinionsOnGameplayEvent.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_KillAllMinionsOnGameplayEvent.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_KillAllMinionsOnGameplayEvent>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_KillAllMinionsOnGameplayEvent.Server>.NativeClassPtr);
        Script_KillAllMinionsOnGameplayEvent.Server.NativeMethodInfoPtr_OnGameplayEvent_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_KillAllMinionsOnGameplayEvent.Server>.NativeClassPtr, 100664616);
        Script_KillAllMinionsOnGameplayEvent.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_KillAllMinionsOnGameplayEvent.Server>.NativeClassPtr, 100664617);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
