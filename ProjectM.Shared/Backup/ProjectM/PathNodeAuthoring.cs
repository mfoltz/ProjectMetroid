// Decompiled with JetBrains decompiler
// Type: ProjectM.PathNodeAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class PathNodeAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_WaitNode;
    private static readonly IntPtr NativeFieldInfoPtr_WaitDuration;
    private static readonly IntPtr NativeFieldInfoPtr_UseWaitRotation;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747465, XrefRangeEnd = 747466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PathNodeAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathNodeAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PathNodeAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PathNodeAuthoring()
    {
      Il2CppClassPointerStore<PathNodeAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PathNodeAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathNodeAuthoring>.NativeClassPtr);
      PathNodeAuthoring.NativeFieldInfoPtr_WaitNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathNodeAuthoring>.NativeClassPtr, nameof (WaitNode));
      PathNodeAuthoring.NativeFieldInfoPtr_WaitDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathNodeAuthoring>.NativeClassPtr, nameof (WaitDuration));
      PathNodeAuthoring.NativeFieldInfoPtr_UseWaitRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathNodeAuthoring>.NativeClassPtr, nameof (UseWaitRotation));
      PathNodeAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathNodeAuthoring>.NativeClassPtr, 100665810);
    }

    public PathNodeAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool WaitNode
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PathNodeAuthoring.NativeFieldInfoPtr_WaitNode));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PathNodeAuthoring.NativeFieldInfoPtr_WaitNode)) = value;
      }
    }

    public unsafe float WaitDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PathNodeAuthoring.NativeFieldInfoPtr_WaitDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PathNodeAuthoring.NativeFieldInfoPtr_WaitDuration)) = value;
      }
    }

    public unsafe bool UseWaitRotation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PathNodeAuthoring.NativeFieldInfoPtr_UseWaitRotation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PathNodeAuthoring.NativeFieldInfoPtr_UseWaitRotation)) = value;
      }
    }
  }
}
