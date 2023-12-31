// Decompiled with JetBrains decompiler
// Type: ProjectM.TileModelHeightLevels
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileModelHeightLevels
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinHeightLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHeightLevel;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HeightLevel_Public_get_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LevelCount_Public_get_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_byref_TileModelHeightLevels_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ContainsHeightLevel_Public_Boolean_Byte_0;
    [FieldOffset(0)]
    public readonly byte MinHeightLevel;
    [FieldOffset(1)]
    public readonly byte MaxHeightLevel;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 254391, RefRangeEnd = 254395, XrefRangeStart = 254391, XrefRangeEnd = 254395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileModelHeightLevels(byte minHeightLevel, byte maxHeightLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &minHeightLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxHeightLevel;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelHeightLevels.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe byte HeightLevel
    {
      [CallerCount(83), CachedScanResults(RefRangeStart = 438794, RefRangeEnd = 438877, XrefRangeStart = 438794, XrefRangeEnd = 438877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelHeightLevels.NativeMethodInfoPtr_get_HeightLevel_Public_get_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe byte LevelCount
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 732144, RefRangeEnd = 732148, XrefRangeStart = 732144, XrefRangeEnd = 732144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelHeightLevels.NativeMethodInfoPtr_get_LevelCount_Public_get_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(byte*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 732148, RefRangeEnd = 732149, XrefRangeStart = 732148, XrefRangeEnd = 732148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Intersects([In] ref TileModelHeightLevels otherRange)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref otherRange;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelHeightLevels.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_TileModelHeightLevels_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 732149, RefRangeEnd = 732150, XrefRangeStart = 732149, XrefRangeEnd = 732149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ContainsHeightLevel(byte heightLevel)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &heightLevel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelHeightLevels.NativeMethodInfoPtr_ContainsHeightLevel_Public_Boolean_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileModelHeightLevels()
    {
      Il2CppClassPointerStore<TileModelHeightLevels>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TileModelHeightLevels));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModelHeightLevels>.NativeClassPtr);
      TileModelHeightLevels.NativeFieldInfoPtr_MinHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelHeightLevels>.NativeClassPtr, nameof (MinHeightLevel));
      TileModelHeightLevels.NativeFieldInfoPtr_MaxHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelHeightLevels>.NativeClassPtr, nameof (MaxHeightLevel));
      TileModelHeightLevels.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelHeightLevels>.NativeClassPtr, 100664681);
      TileModelHeightLevels.NativeMethodInfoPtr_get_HeightLevel_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelHeightLevels>.NativeClassPtr, 100664682);
      TileModelHeightLevels.NativeMethodInfoPtr_get_LevelCount_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelHeightLevels>.NativeClassPtr, 100664683);
      TileModelHeightLevels.NativeMethodInfoPtr_Intersects_Public_Boolean_byref_TileModelHeightLevels_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelHeightLevels>.NativeClassPtr, 100664684);
      TileModelHeightLevels.NativeMethodInfoPtr_ContainsHeightLevel_Public_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelHeightLevels>.NativeClassPtr, 100664685);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileModelHeightLevels>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
