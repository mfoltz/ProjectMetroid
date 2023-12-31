// Decompiled with JetBrains decompiler
// Type: ProjectM.DashSpawn
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DashSpawn
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseMinMaxRange;
    [FieldOffset(0)]
    public float MinRange;
    [FieldOffset(4)]
    public float MaxRange;
    [FieldOffset(8)]
    public bool UseMinMaxRange;

    static DashSpawn()
    {
      Il2CppClassPointerStore<DashSpawn>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DashSpawn));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DashSpawn>.NativeClassPtr);
      DashSpawn.NativeFieldInfoPtr_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DashSpawn>.NativeClassPtr, nameof (MinRange));
      DashSpawn.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DashSpawn>.NativeClassPtr, nameof (MaxRange));
      DashSpawn.NativeFieldInfoPtr_UseMinMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DashSpawn>.NativeClassPtr, nameof (UseMinMaxRange));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DashSpawn>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
