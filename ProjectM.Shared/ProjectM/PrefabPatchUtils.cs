// Decompiled with JetBrains decompiler
// Type: ProjectM.PrefabPatchUtils
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace ProjectM
{
  public static class PrefabPatchUtils : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_HasValueChanged_Public_Static_Boolean_Object_String_0;

    [CallerCount(1858)]
    [CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool HasValueChanged(UnityEngine.Object obj, string propPath)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(propPath);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrefabPatchUtils.NativeMethodInfoPtr_HasValueChanged_Public_Static_Boolean_Object_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PrefabPatchUtils()
    {
      Il2CppClassPointerStore<PrefabPatchUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PrefabPatchUtils));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabPatchUtils>.NativeClassPtr);
      PrefabPatchUtils.NativeMethodInfoPtr_HasValueChanged_Public_Static_Boolean_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPatchUtils>.NativeClassPtr, 100664575);
    }

    public PrefabPatchUtils(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
