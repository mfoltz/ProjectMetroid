// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.DyeColorSetupFlagOffsetBuffer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DyeColorSetupFlagOffsetBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_NumFlags;
    [FieldOffset(0)]
    public int StartIndex;
    [FieldOffset(4)]
    public int NumFlags;

    static DyeColorSetupFlagOffsetBuffer()
    {
      Il2CppClassPointerStore<DyeColorSetupFlagOffsetBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (DyeColorSetupFlagOffsetBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DyeColorSetupFlagOffsetBuffer>.NativeClassPtr);
      DyeColorSetupFlagOffsetBuffer.NativeFieldInfoPtr_StartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeColorSetupFlagOffsetBuffer>.NativeClassPtr, nameof (StartIndex));
      DyeColorSetupFlagOffsetBuffer.NativeFieldInfoPtr_NumFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeColorSetupFlagOffsetBuffer>.NativeClassPtr, nameof (NumFlags));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DyeColorSetupFlagOffsetBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
