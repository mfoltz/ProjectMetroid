// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.AssetSwapping.AssetSwapFlagsExtensions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM.CastleBuilding.AssetSwapping
{
  public static class AssetSwapFlagsExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_HasAll_Public_Static_Boolean_AssetSwapFlags_AssetSwapFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasAny_Public_Static_Boolean_AssetSwapFlags_AssetSwapFlags_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasNone_Public_Static_Boolean_AssetSwapFlags_AssetSwapFlags_0;

    [CallerCount(0)]
    public static unsafe bool HasAll(this AssetSwapFlags source, AssetSwapFlags flags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSwapFlagsExtensions.NativeMethodInfoPtr_HasAll_Public_Static_Boolean_AssetSwapFlags_AssetSwapFlags_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool HasAny(this AssetSwapFlags source, AssetSwapFlags flags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSwapFlagsExtensions.NativeMethodInfoPtr_HasAny_Public_Static_Boolean_AssetSwapFlags_AssetSwapFlags_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool HasNone(this AssetSwapFlags source, AssetSwapFlags flags)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &source;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSwapFlagsExtensions.NativeMethodInfoPtr_HasNone_Public_Static_Boolean_AssetSwapFlags_AssetSwapFlags_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AssetSwapFlagsExtensions()
    {
      Il2CppClassPointerStore<AssetSwapFlagsExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding.AssetSwapping", nameof (AssetSwapFlagsExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSwapFlagsExtensions>.NativeClassPtr);
      AssetSwapFlagsExtensions.NativeMethodInfoPtr_HasAll_Public_Static_Boolean_AssetSwapFlags_AssetSwapFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFlagsExtensions>.NativeClassPtr, 100690028);
      AssetSwapFlagsExtensions.NativeMethodInfoPtr_HasAny_Public_Static_Boolean_AssetSwapFlags_AssetSwapFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFlagsExtensions>.NativeClassPtr, 100690029);
      AssetSwapFlagsExtensions.NativeMethodInfoPtr_HasNone_Public_Static_Boolean_AssetSwapFlags_AssetSwapFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwapFlagsExtensions>.NativeClassPtr, 100690030);
    }

    public AssetSwapFlagsExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
