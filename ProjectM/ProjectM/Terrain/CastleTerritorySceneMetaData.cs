// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.CastleTerritorySceneMetaData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleTerritorySceneMetaData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LengthBits;
    private static readonly System.IntPtr NativeFieldInfoPtr_PackedData;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxPackSizeBytes_Public_Static_get_Int32_0;
    [FieldOffset(0)]
    public int LengthBits;
    [FieldOffset(4)]
    public FixedList512<byte> PackedData;

    public static unsafe int MaxPackSizeBytes
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124405, XrefRangeEnd = 1124408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleTerritorySceneMetaData.NativeMethodInfoPtr_get_MaxPackSizeBytes_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static CastleTerritorySceneMetaData()
    {
      Il2CppClassPointerStore<CastleTerritorySceneMetaData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Terrain", nameof (CastleTerritorySceneMetaData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleTerritorySceneMetaData>.NativeClassPtr);
      CastleTerritorySceneMetaData.NativeFieldInfoPtr_LengthBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritorySceneMetaData>.NativeClassPtr, nameof (LengthBits));
      CastleTerritorySceneMetaData.NativeFieldInfoPtr_PackedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTerritorySceneMetaData>.NativeClassPtr, nameof (PackedData));
      CastleTerritorySceneMetaData.NativeMethodInfoPtr_get_MaxPackSizeBytes_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleTerritorySceneMetaData>.NativeClassPtr, 100689211);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleTerritorySceneMetaData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
