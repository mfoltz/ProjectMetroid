// Decompiled with JetBrains decompiler
// Type: ProjectM.BodyPartColliderUseSet
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct BodyPartColliderUseSet
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Head;
    private static readonly System.IntPtr NativeFieldInfoPtr_Neck;
    private static readonly System.IntPtr NativeFieldInfoPtr_Chest;
    private static readonly System.IntPtr NativeFieldInfoPtr_Gut;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pelvis;
    private static readonly System.IntPtr NativeFieldInfoPtr_LeftLeg;
    private static readonly System.IntPtr NativeFieldInfoPtr_RightLeg;
    private static readonly System.IntPtr NativeFieldInfoPtr_LeftArm;
    private static readonly System.IntPtr NativeFieldInfoPtr_RightArm;
    private static readonly System.IntPtr NativeFieldInfoPtr_Mount;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cloak;
    [FieldOffset(0)]
    public bool Head;
    [FieldOffset(1)]
    public bool Neck;
    [FieldOffset(2)]
    public bool Chest;
    [FieldOffset(3)]
    public bool Gut;
    [FieldOffset(4)]
    public bool Pelvis;
    [FieldOffset(5)]
    public bool LeftLeg;
    [FieldOffset(6)]
    public bool RightLeg;
    [FieldOffset(7)]
    public bool LeftArm;
    [FieldOffset(8)]
    public bool RightArm;
    [FieldOffset(9)]
    public bool Mount;
    [FieldOffset(10)]
    public bool Cloak;

    static BodyPartColliderUseSet()
    {
      Il2CppClassPointerStore<BodyPartColliderUseSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BodyPartColliderUseSet));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodyPartColliderUseSet>.NativeClassPtr);
      BodyPartColliderUseSet.NativeFieldInfoPtr_Head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartColliderUseSet>.NativeClassPtr, nameof (Head));
      BodyPartColliderUseSet.NativeFieldInfoPtr_Neck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartColliderUseSet>.NativeClassPtr, nameof (Neck));
      BodyPartColliderUseSet.NativeFieldInfoPtr_Chest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartColliderUseSet>.NativeClassPtr, nameof (Chest));
      BodyPartColliderUseSet.NativeFieldInfoPtr_Gut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartColliderUseSet>.NativeClassPtr, nameof (Gut));
      BodyPartColliderUseSet.NativeFieldInfoPtr_Pelvis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartColliderUseSet>.NativeClassPtr, nameof (Pelvis));
      BodyPartColliderUseSet.NativeFieldInfoPtr_LeftLeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartColliderUseSet>.NativeClassPtr, nameof (LeftLeg));
      BodyPartColliderUseSet.NativeFieldInfoPtr_RightLeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartColliderUseSet>.NativeClassPtr, nameof (RightLeg));
      BodyPartColliderUseSet.NativeFieldInfoPtr_LeftArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartColliderUseSet>.NativeClassPtr, nameof (LeftArm));
      BodyPartColliderUseSet.NativeFieldInfoPtr_RightArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartColliderUseSet>.NativeClassPtr, nameof (RightArm));
      BodyPartColliderUseSet.NativeFieldInfoPtr_Mount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartColliderUseSet>.NativeClassPtr, nameof (Mount));
      BodyPartColliderUseSet.NativeFieldInfoPtr_Cloak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodyPartColliderUseSet>.NativeClassPtr, nameof (Cloak));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BodyPartColliderUseSet>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
