// Decompiled with JetBrains decompiler
// Type: ProjectM.GetOwnerRotation
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GetOwnerRotation
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetDegreesClockwise;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_InverseRotation;
    [FieldOffset(0)]
    public float OffsetDegreesClockwise;
    [FieldOffset(4)]
    public GetRotationType Type;
    [FieldOffset(8)]
    public GetOwnerRotationComponent.GetRotationSource RotationSource;
    [FieldOffset(12)]
    public bool InverseRotation;

    static GetOwnerRotation()
    {
      Il2CppClassPointerStore<GetOwnerRotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (GetOwnerRotation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetOwnerRotation>.NativeClassPtr);
      GetOwnerRotation.NativeFieldInfoPtr_OffsetDegreesClockwise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOwnerRotation>.NativeClassPtr, nameof (OffsetDegreesClockwise));
      GetOwnerRotation.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOwnerRotation>.NativeClassPtr, nameof (Type));
      GetOwnerRotation.NativeFieldInfoPtr_RotationSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOwnerRotation>.NativeClassPtr, nameof (RotationSource));
      GetOwnerRotation.NativeFieldInfoPtr_InverseRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOwnerRotation>.NativeClassPtr, nameof (InverseRotation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetOwnerRotation>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
