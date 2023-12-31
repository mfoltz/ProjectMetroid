// Decompiled with JetBrains decompiler
// Type: ProjectM.GameDataBootstrap
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Scenes;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class GameDataBootstrap : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_GameDataSubScenes;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734943, XrefRangeEnd = 734951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameDataBootstrap()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataBootstrap>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataBootstrap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameDataBootstrap()
    {
      Il2CppClassPointerStore<GameDataBootstrap>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameDataBootstrap));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataBootstrap>.NativeClassPtr);
      GameDataBootstrap.NativeFieldInfoPtr_GameDataSubScenes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataBootstrap>.NativeClassPtr, nameof (GameDataSubScenes));
      GameDataBootstrap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataBootstrap>.NativeClassPtr, 100664906);
    }

    public GameDataBootstrap(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<SubScene> GameDataSubScenes
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataBootstrap.NativeFieldInfoPtr_GameDataSubScenes));
        return pointer == IntPtr.Zero ? (List<SubScene>) null : new List<SubScene>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameDataBootstrap.NativeFieldInfoPtr_GameDataSubScenes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
