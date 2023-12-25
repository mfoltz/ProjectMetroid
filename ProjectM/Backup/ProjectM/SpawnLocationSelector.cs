// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnLocationSelector
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpawnLocationSelector
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LocationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsLocked;
    [FieldOffset(0)]
    public SpawnLocationType LocationType;
    [FieldOffset(4)]
    public bool IsLocked;

    static SpawnLocationSelector()
    {
      Il2CppClassPointerStore<SpawnLocationSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SpawnLocationSelector));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnLocationSelector>.NativeClassPtr);
      SpawnLocationSelector.NativeFieldInfoPtr_LocationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnLocationSelector>.NativeClassPtr, nameof (LocationType));
      SpawnLocationSelector.NativeFieldInfoPtr_IsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnLocationSelector>.NativeClassPtr, nameof (IsLocked));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnLocationSelector>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
