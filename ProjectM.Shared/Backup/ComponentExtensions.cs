// Decompiled with JetBrains decompiler
// Type: ComponentExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

#nullable disable
public static class ComponentExtensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHierarchicalPath_Public_Static_String_Transform_String_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717255, XrefRangeEnd = 717268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetHierarchicalPath(this Transform transform, string separator = ">")
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(separator);
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ComponentExtensions.NativeMethodInfoPtr_GetHierarchicalPath_Public_Static_String_Transform_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  static ComponentExtensions()
  {
    Il2CppClassPointerStore<ComponentExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (ComponentExtensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComponentExtensions>.NativeClassPtr);
    ComponentExtensions.NativeMethodInfoPtr_GetHierarchicalPath_Public_Static_String_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentExtensions>.NativeClassPtr, 100663524);
  }

  public ComponentExtensions(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
