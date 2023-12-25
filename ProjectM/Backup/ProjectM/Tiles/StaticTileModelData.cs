// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.StaticTileModelData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StaticTileModelData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHeightLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_MultiLevelTileModel;
    [FieldOffset(0)]
    public byte MaxHeightLevel;
    [FieldOffset(1)]
    public bool MultiLevelTileModel;

    static StaticTileModelData()
    {
      Il2CppClassPointerStore<StaticTileModelData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (StaticTileModelData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticTileModelData>.NativeClassPtr);
      StaticTileModelData.NativeFieldInfoPtr_MaxHeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTileModelData>.NativeClassPtr, nameof (MaxHeightLevel));
      StaticTileModelData.NativeFieldInfoPtr_MultiLevelTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticTileModelData>.NativeClassPtr, nameof (MultiLevelTileModel));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StaticTileModelData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
