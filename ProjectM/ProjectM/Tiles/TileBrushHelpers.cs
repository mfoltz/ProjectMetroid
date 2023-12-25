// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileBrushHelpers
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace ProjectM.Tiles
{
  public static class TileBrushHelpers : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsBrushOfCategory_Public_Static_Boolean_TileBrushComponent_TileBrushType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetBrushCategory_Public_Static_Boolean_TileBrushComponent_byref_TileBrushType_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1086021, RefRangeEnd = 1086022, XrefRangeStart = 1086001, XrefRangeEnd = 1086021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsBrushOfCategory(
      TileBrushComponent brush,
      TileBrushType brushCategory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) brush);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &brushCategory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBrushHelpers.NativeMethodInfoPtr_IsBrushOfCategory_Public_Static_Boolean_TileBrushComponent_TileBrushType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086022, XrefRangeEnd = 1086038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetBrushCategory(
      TileBrushComponent brush,
      out TileBrushType tileBrushType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) brush);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileBrushType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileBrushHelpers.NativeMethodInfoPtr_TryGetBrushCategory_Public_Static_Boolean_TileBrushComponent_byref_TileBrushType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileBrushHelpers()
    {
      Il2CppClassPointerStore<TileBrushHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (TileBrushHelpers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileBrushHelpers>.NativeClassPtr);
      TileBrushHelpers.NativeMethodInfoPtr_IsBrushOfCategory_Public_Static_Boolean_TileBrushComponent_TileBrushType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushHelpers>.NativeClassPtr, 100685546);
      TileBrushHelpers.NativeMethodInfoPtr_TryGetBrushCategory_Public_Static_Boolean_TileBrushComponent_byref_TileBrushType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBrushHelpers>.NativeClassPtr, 100685547);
    }

    public TileBrushHelpers(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
