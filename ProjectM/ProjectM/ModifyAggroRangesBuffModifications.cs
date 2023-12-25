// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyAggroRangesBuffModifications
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ModifyAggroRangesBuffModifications
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AggroCircleRadiusModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_AggroConeRadiusModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlertCircleRadiusModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlertConeRadiusModId;
    [FieldOffset(0)]
    public ModificationId AggroCircleRadiusModId;
    [FieldOffset(4)]
    public ModificationId AggroConeRadiusModId;
    [FieldOffset(8)]
    public ModificationId AlertCircleRadiusModId;
    [FieldOffset(12)]
    public ModificationId AlertConeRadiusModId;

    static ModifyAggroRangesBuffModifications()
    {
      Il2CppClassPointerStore<ModifyAggroRangesBuffModifications>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ModifyAggroRangesBuffModifications));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyAggroRangesBuffModifications>.NativeClassPtr);
      ModifyAggroRangesBuffModifications.NativeFieldInfoPtr_AggroCircleRadiusModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyAggroRangesBuffModifications>.NativeClassPtr, nameof (AggroCircleRadiusModId));
      ModifyAggroRangesBuffModifications.NativeFieldInfoPtr_AggroConeRadiusModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyAggroRangesBuffModifications>.NativeClassPtr, nameof (AggroConeRadiusModId));
      ModifyAggroRangesBuffModifications.NativeFieldInfoPtr_AlertCircleRadiusModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyAggroRangesBuffModifications>.NativeClassPtr, nameof (AlertCircleRadiusModId));
      ModifyAggroRangesBuffModifications.NativeFieldInfoPtr_AlertConeRadiusModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyAggroRangesBuffModifications>.NativeClassPtr, nameof (AlertConeRadiusModId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyAggroRangesBuffModifications>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
