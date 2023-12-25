// Decompiled with JetBrains decompiler
// Type: ProjectM.SunBlocker.SunBlockerRegion
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.SunBlocker
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SunBlockerRegion
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Data;
    [FieldOffset(0)]
    public BlobAssetReference<PolygonRegionBlob> Data;

    static SunBlockerRegion()
    {
      Il2CppClassPointerStore<SunBlockerRegion>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.SunBlocker", nameof (SunBlockerRegion));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SunBlockerRegion>.NativeClassPtr);
      SunBlockerRegion.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SunBlockerRegion>.NativeClassPtr, nameof (Data));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SunBlockerRegion>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
