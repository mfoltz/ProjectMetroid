// Decompiled with JetBrains decompiler
// Type: ProjectM.MinionMaster
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MinionMaster
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TotalMaxMinions;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinionSpawnsThisFrame;
    [FieldOffset(0)]
    public int TotalMaxMinions;
    [FieldOffset(4)]
    public int MinionSpawnsThisFrame;

    static MinionMaster()
    {
      Il2CppClassPointerStore<MinionMaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MinionMaster));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinionMaster>.NativeClassPtr);
      MinionMaster.NativeFieldInfoPtr_TotalMaxMinions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinionMaster>.NativeClassPtr, nameof (TotalMaxMinions));
      MinionMaster.NativeFieldInfoPtr_MinionSpawnsThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinionMaster>.NativeClassPtr, nameof (MinionSpawnsThisFrame));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MinionMaster>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
