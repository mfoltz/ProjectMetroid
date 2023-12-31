// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.JewelArithmeticModification
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct JewelArithmeticModification
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Id;
    [FieldOffset(0)]
    public Entity TargetEntity;
    [FieldOffset(8)]
    public SpellModArithmeticModifiableTarget TargetType;
    [FieldOffset(12)]
    public ModificationId Id;

    static JewelArithmeticModification()
    {
      Il2CppClassPointerStore<JewelArithmeticModification>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (JewelArithmeticModification));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelArithmeticModification>.NativeClassPtr);
      JewelArithmeticModification.NativeFieldInfoPtr_TargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelArithmeticModification>.NativeClassPtr, nameof (TargetEntity));
      JewelArithmeticModification.NativeFieldInfoPtr_TargetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelArithmeticModification>.NativeClassPtr, nameof (TargetType));
      JewelArithmeticModification.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelArithmeticModification>.NativeClassPtr, nameof (Id));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelArithmeticModification>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
