// Decompiled with JetBrains decompiler
// Type: ProjectM.DropTableOnDeath
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DropTableOnDeath
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Dropped;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomDropArc;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRange;
    [FieldOffset(0)]
    public bool Dropped;
    [FieldOffset(4)]
    public PrefabGUID CustomDropArc;
    [FieldOffset(8)]
    public float MinRange;
    [FieldOffset(12)]
    public float MaxRange;

    static DropTableOnDeath()
    {
      Il2CppClassPointerStore<DropTableOnDeath>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DropTableOnDeath));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropTableOnDeath>.NativeClassPtr);
      DropTableOnDeath.NativeFieldInfoPtr_Dropped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableOnDeath>.NativeClassPtr, nameof (Dropped));
      DropTableOnDeath.NativeFieldInfoPtr_CustomDropArc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableOnDeath>.NativeClassPtr, nameof (CustomDropArc));
      DropTableOnDeath.NativeFieldInfoPtr_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableOnDeath>.NativeClassPtr, nameof (MinRange));
      DropTableOnDeath.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableOnDeath>.NativeClassPtr, nameof (MaxRange));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropTableOnDeath>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
