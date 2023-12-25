// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.MusicAmbienceData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Audio
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MusicAmbienceData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Track;
    private static readonly System.IntPtr NativeFieldInfoPtr_Indoor;
    private static readonly System.IntPtr NativeFieldInfoPtr_RainingAmount;
    private static readonly System.IntPtr NativeFieldInfoPtr_SnowingAmount;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MusicAmbienceData_0;
    [FieldOffset(0)]
    public float Track;
    [FieldOffset(4)]
    public float Indoor;
    [FieldOffset(8)]
    public float RainingAmount;
    [FieldOffset(12)]
    public float SnowingAmount;

    [CallerCount(0)]
    public virtual unsafe bool Equals(MusicAmbienceData other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MusicAmbienceData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MusicAmbienceData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static MusicAmbienceData()
    {
      Il2CppClassPointerStore<MusicAmbienceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (MusicAmbienceData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicAmbienceData>.NativeClassPtr);
      MusicAmbienceData.NativeFieldInfoPtr_Track = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceData>.NativeClassPtr, nameof (Track));
      MusicAmbienceData.NativeFieldInfoPtr_Indoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceData>.NativeClassPtr, nameof (Indoor));
      MusicAmbienceData.NativeFieldInfoPtr_RainingAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceData>.NativeClassPtr, nameof (RainingAmount));
      MusicAmbienceData.NativeFieldInfoPtr_SnowingAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceData>.NativeClassPtr, nameof (SnowingAmount));
      MusicAmbienceData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MusicAmbienceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicAmbienceData>.NativeClassPtr, 100690388);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicAmbienceData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
