// Decompiled with JetBrains decompiler
// Type: ProjectM.StunlockBehaviour
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class StunlockBehaviour : MonoBehaviour
  {
    private static readonly IntPtr NativeMethodInfoPtr_GetActiveVersion_Protected_Virtual_New_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_New_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    [CallerCount(1474)]
    [CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe int GetActiveVersion()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunlockBehaviour.NativeMethodInfoPtr_GetActiveVersion_Protected_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunlockBehaviour.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_New_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunlockBehaviour()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunlockBehaviour>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunlockBehaviour.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StunlockBehaviour()
    {
      Il2CppClassPointerStore<StunlockBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (StunlockBehaviour));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunlockBehaviour>.NativeClassPtr);
      StunlockBehaviour.NativeMethodInfoPtr_GetActiveVersion_Protected_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunlockBehaviour>.NativeClassPtr, 100664576);
      StunlockBehaviour.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_New_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunlockBehaviour>.NativeClassPtr, 100664577);
      StunlockBehaviour.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunlockBehaviour>.NativeClassPtr, 100664578);
    }

    public StunlockBehaviour(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
