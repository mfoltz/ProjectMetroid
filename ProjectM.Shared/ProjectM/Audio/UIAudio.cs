// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.UIAudio
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Fmod;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Audio
{
  public static class UIAudio : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__DefaultWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_debug;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultWorld_Private_Static_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DebugInfo_Public_Static_Void_String_String_GameObject_Boolean_Nullable_1_FmodEvent_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Static_Void_UISoundMapping_UISoundType_String_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Static_Void_EntityManager_UISoundMapping_UISoundType_String_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Static_Void_FmodEvent_String_GameObject_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Static_Void_FmodEventGuid_String_GameObject_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Static_Void_EntityManager_FmodEventGuid_String_GameObject_Boolean_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795844, XrefRangeEnd = 795861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe World GetDefaultWorld()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIAudio.NativeMethodInfoPtr_GetDefaultWorld_Private_Static_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DebugInfo(
      string playInfo,
      string debugInfo,
      GameObject debugObject,
      bool played,
      Il2CppSystem.Nullable<FmodEvent> fmodEvent = null,
      bool calledFromUiAudio = false,
      bool enumNone = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(playInfo);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(debugInfo);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) debugObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &played;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) fmodEvent));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &calledFromUiAudio;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &enumNone;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIAudio.NativeMethodInfoPtr_DebugInfo_Public_Static_Void_String_String_GameObject_Boolean_Nullable_1_FmodEvent_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(29)]
    [CachedScanResults(RefRangeStart = 795889, RefRangeEnd = 795918, XrefRangeStart = 795861, XrefRangeEnd = 795889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Play(
      UISoundMapping soundMapping,
      UISoundType soundType,
      string debugInfo,
      GameObject debugObject = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) soundMapping);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &soundType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(debugInfo);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) debugObject);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIAudio.NativeMethodInfoPtr_Play_Public_Static_Void_UISoundMapping_UISoundType_String_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(29)]
    [CachedScanResults(RefRangeStart = 795943, RefRangeEnd = 795972, XrefRangeStart = 795918, XrefRangeEnd = 795943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Play(
      EntityManager entityManager,
      UISoundMapping soundMapping,
      UISoundType soundType,
      string debugInfo,
      GameObject debugObject = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) soundMapping);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &soundType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(debugInfo);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) debugObject);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIAudio.NativeMethodInfoPtr_Play_Public_Static_Void_EntityManager_UISoundMapping_UISoundType_String_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 795983, RefRangeEnd = 795996, XrefRangeStart = 795972, XrefRangeEnd = 795983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Play(
      FmodEvent fmodEvent,
      string debugInfo,
      GameObject debugObject = null,
      bool calledFromUiAudio = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) fmodEvent));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(debugInfo);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) debugObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &calledFromUiAudio;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIAudio.NativeMethodInfoPtr_Play_Public_Static_Void_FmodEvent_String_GameObject_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 796027, RefRangeEnd = 796032, XrefRangeStart = 795996, XrefRangeEnd = 796027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Play(
      FmodEventGuid fmodGuid,
      string debugInfo,
      GameObject debugObject = null,
      bool calledFromUiAudio = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &fmodGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(debugInfo);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) debugObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &calledFromUiAudio;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIAudio.NativeMethodInfoPtr_Play_Public_Static_Void_FmodEventGuid_String_GameObject_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 796052, RefRangeEnd = 796058, XrefRangeStart = 796032, XrefRangeEnd = 796052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Play(
      EntityManager entityManager,
      FmodEventGuid fmodGuid,
      string debugInfo,
      GameObject debugObject = null,
      bool calledFromUiAudio = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fmodGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(debugInfo);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) debugObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &calledFromUiAudio;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIAudio.NativeMethodInfoPtr_Play_Public_Static_Void_EntityManager_FmodEventGuid_String_GameObject_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UIAudio()
    {
      Il2CppClassPointerStore<UIAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Audio", nameof (UIAudio));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIAudio>.NativeClassPtr);
      UIAudio.NativeFieldInfoPtr__DefaultWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAudio>.NativeClassPtr, nameof (_DefaultWorld));
      UIAudio.NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAudio>.NativeClassPtr, nameof (debug));
      UIAudio.NativeMethodInfoPtr_GetDefaultWorld_Private_Static_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAudio>.NativeClassPtr, 100670238);
      UIAudio.NativeMethodInfoPtr_DebugInfo_Public_Static_Void_String_String_GameObject_Boolean_Nullable_1_FmodEvent_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAudio>.NativeClassPtr, 100670239);
      UIAudio.NativeMethodInfoPtr_Play_Public_Static_Void_UISoundMapping_UISoundType_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAudio>.NativeClassPtr, 100670240);
      UIAudio.NativeMethodInfoPtr_Play_Public_Static_Void_EntityManager_UISoundMapping_UISoundType_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAudio>.NativeClassPtr, 100670241);
      UIAudio.NativeMethodInfoPtr_Play_Public_Static_Void_FmodEvent_String_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAudio>.NativeClassPtr, 100670242);
      UIAudio.NativeMethodInfoPtr_Play_Public_Static_Void_FmodEventGuid_String_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAudio>.NativeClassPtr, 100670243);
      UIAudio.NativeMethodInfoPtr_Play_Public_Static_Void_EntityManager_FmodEventGuid_String_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAudio>.NativeClassPtr, 100670244);
    }

    public UIAudio(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe World _DefaultWorld
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UIAudio.NativeFieldInfoPtr__DefaultWorld, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIAudio.NativeFieldInfoPtr__DefaultWorld, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe bool debug
    {
      get
      {
        bool debug;
        IL2CPP.il2cpp_field_static_get_value(UIAudio.NativeFieldInfoPtr_debug, (void*) &debug);
        return debug;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UIAudio.NativeFieldInfoPtr_debug, (void*) &value);
      }
    }
  }
}
