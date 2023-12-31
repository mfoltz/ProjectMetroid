// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.JewelInstanceSpawnData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct JewelInstanceSpawnData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemLevel;
    [FieldOffset(0)]
    public int ItemLevel;

    static JewelInstanceSpawnData()
    {
      Il2CppClassPointerStore<JewelInstanceSpawnData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (JewelInstanceSpawnData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelInstanceSpawnData>.NativeClassPtr);
      JewelInstanceSpawnData.NativeFieldInfoPtr_ItemLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelInstanceSpawnData>.NativeClassPtr, nameof (ItemLevel));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelInstanceSpawnData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
