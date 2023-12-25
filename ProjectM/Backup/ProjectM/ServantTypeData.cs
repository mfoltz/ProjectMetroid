// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantTypeData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServantTypeData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ServantType;
    private static readonly System.IntPtr NativeFieldInfoPtr_GenderType;
    [FieldOffset(0)]
    public ServantType ServantType;
    [FieldOffset(4)]
    public GenderType GenderType;

    static ServantTypeData()
    {
      Il2CppClassPointerStore<ServantTypeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServantTypeData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantTypeData>.NativeClassPtr);
      ServantTypeData.NativeFieldInfoPtr_ServantType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantTypeData>.NativeClassPtr, nameof (ServantType));
      ServantTypeData.NativeFieldInfoPtr_GenderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantTypeData>.NativeClassPtr, nameof (GenderType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantTypeData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
