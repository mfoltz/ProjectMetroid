// Decompiled with JetBrains decompiler
// Type: ProjectM.ComponentHubBehaviour
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
  public class ComponentHubBehaviour : MonoBehaviour
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ComponentHubBehaviour()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComponentHubBehaviour>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ComponentHubBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ComponentHubBehaviour()
    {
      Il2CppClassPointerStore<ComponentHubBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ComponentHubBehaviour));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComponentHubBehaviour>.NativeClassPtr);
      ComponentHubBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentHubBehaviour>.NativeClassPtr, 100664092);
    }

    public ComponentHubBehaviour(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
