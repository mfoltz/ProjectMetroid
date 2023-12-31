// Decompiled with JetBrains decompiler
// Type: ProjectM.DiminishingReturn
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DiminishingReturn
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DiminishingBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_SCTPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllowOnUnitTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllowFromUnitOwner;
    [FieldOffset(0)]
    public PrefabGUID DiminishingBuff;
    [FieldOffset(4)]
    public PrefabGUID SCTPrefab;
    [FieldOffset(8)]
    public bool AllowOnUnitTarget;
    [FieldOffset(9)]
    public bool AllowFromUnitOwner;

    static DiminishingReturn()
    {
      Il2CppClassPointerStore<DiminishingReturn>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DiminishingReturn));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiminishingReturn>.NativeClassPtr);
      DiminishingReturn.NativeFieldInfoPtr_DiminishingBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiminishingReturn>.NativeClassPtr, nameof (DiminishingBuff));
      DiminishingReturn.NativeFieldInfoPtr_SCTPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiminishingReturn>.NativeClassPtr, nameof (SCTPrefab));
      DiminishingReturn.NativeFieldInfoPtr_AllowOnUnitTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiminishingReturn>.NativeClassPtr, nameof (AllowOnUnitTarget));
      DiminishingReturn.NativeFieldInfoPtr_AllowFromUnitOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiminishingReturn>.NativeClassPtr, nameof (AllowFromUnitOwner));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DiminishingReturn>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
